using ASS1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASS1.Contexts
{
    public class Contexet : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Topic>().HasKey(t => t.Id);
            //modelBuilder.Entity<student>().HasKey(t => t.Id);
            //modelBuilder.Entity<Stud_Course>().HasKey(t => t.stud_ID);
            //modelBuilder.Entity<Instructor>().HasKey(t => t.ID);
            //modelBuilder.Entity<Department>().HasKey(t => t.Ins_ID);
            //modelBuilder.Entity<CourseList>().HasKey(t => t.Course_ID);
            //modelBuilder.Entity<Course>().HasKey(t => t.Id);

            modelBuilder.Entity<Stud_Course>().HasKey(sc=>new { sc.Course_ID, sc.stud_ID });
            modelBuilder.Entity<CourseList>().HasKey(ci => new {ci.Course_ID,ci.inst_ID });

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database= School;Trusted_Connection=True");
        }
        public DbSet<student> students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Studs { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CourseList> CoursesLists { get; set; }
        public DbSet <Course> Courses { get; set; }

    }
}
