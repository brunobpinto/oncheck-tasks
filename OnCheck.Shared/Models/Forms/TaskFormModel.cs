using System.ComponentModel.DataAnnotations;

namespace OnCheck.Shared.Models.Forms
{
    public class TaskFormModel
    {
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(55, ErrorMessage = "Title must be at most 55 characters")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must select a user")]
        public int? UserId { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Today;

        public string Difficulty { get; set; } = "Easy";

        public bool Completed { get; set; } = false;
    }
}
