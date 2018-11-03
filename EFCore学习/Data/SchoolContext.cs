using EFCore学习.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore学习.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
  
        /// <summary>
        /// 模型创建时
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //指定创建时的表名
            modelBuilder.Entity<Student>().ToTable(nameof(Student));
            modelBuilder.Entity<Enrollment>().ToTable(nameof(Enrollment));
            modelBuilder.Entity<Course>().ToTable(nameof(Course));
        }
    }
}