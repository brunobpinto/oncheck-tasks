using System.Text.Json.Serialization;
namespace OnCheck.Shared.Models;

public class TaskItem
{
    public int Id { get; set; }     // Primary Key
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Difficulty { get; set; } = string.Empty;
    public bool Completed { get; set; } = false;    // We initialize this property by default as false

    // Foreign Key - User
    public int UserId { get; set; }             // This is what links the two models. The Foreign Key. It is always written like this: [ClassName]Id
    [JsonIgnore]
    public User? User { get; set; } = null!;     // This is the property to access the name of the User through the tasks. "= null!" means we guarantee that it will always be a user associated to. 

    // Dados do usuário expostos diretamente
    public string UserFirstName { get; set; } = string.Empty;
    public string UserLastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;   
}

