using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Courses = Set<Course>();
            Lessons = Set<Lesson>();
        }

        // Таблицы базы данных
        public DbSet<Course> Courses { get;  set; }
        public DbSet<Lesson> Lessons { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Дополнительные настройки моделей
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Lessons)
                .WithOne(l => l.Course)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
