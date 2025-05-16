using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!; // Добавлено = null!

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; } // Добавлен знак ?

        [DataType(DataType.Date)]
        [Display(Name = "Дата создания")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string InstructorId { get; set; } = null!; // Добавлено = null!

        // Навигационные свойства
        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}