namespace OnCheck.Shared.Models;
// By using a namespace we can have classes with the same name coexisting in the same project without problems.
// But in order to do this, we need to define the namespace where this class is being made.
// And to access it in other parts of the project, we need to type as an example: "using OnCheck.Shared.Models;"

public class User
{
    public int Id { get; set; }     // Primary Key
    public string FirstName { get; set; } = string.Empty;   // When an object of this class gets created, FirstName is an empty string ("")
    public string LastName { get; set; } = string.Empty;    // The same happens for the other properties that are equal to "string.Empty"
    public string Username { get; set; } = string.Empty;    // The  { get; set; } property allows us to modify and access the value of it
    public string Password { get; set; } = string.Empty;

    // This is a property named Tasks, that is a collection of TaskItem (Name of the tasks model)
    // Since we did " = new List<TaskItem>()", when an User gets created, we also initialize this property with an empty list of TaskItem
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
}