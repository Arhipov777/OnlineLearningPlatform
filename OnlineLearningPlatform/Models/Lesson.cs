using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!; // Добавлено = null!

        [DataType(DataType.MultilineText)]
        public string? Content { get; set; } // Добавлен знак ?

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        // Навигационное свойство
        public virtual Course Course { get; set; } = null!; // Добавлено = null!
    }
}