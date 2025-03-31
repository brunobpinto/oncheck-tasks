using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnCheck.API.Data;
using OnCheck.Shared.Models;
using OnCheck.Shared.Models.Auth;

namespace OnCheck.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly OnCheckDbContext _context;

    public UsersController(OnCheckDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();
        return user;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(RegisterModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest(new { message = "Invalid data" });

        var exists = await _context.Users.AnyAsync(u => u.Username == model.Username);
        if (exists)
            return BadRequest(new { message = "Username already exists" });

        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Username = model.Username,
            Password = model.Password // ideal: com hash
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, User user)
    {
        if (id != user.Id) return BadRequest();
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
