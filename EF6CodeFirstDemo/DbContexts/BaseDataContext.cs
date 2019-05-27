using EF6CodeFirstDemo.Entities;
using EF6CodeFirstDemo.Interfaces;
using System.Data.Entity;

namespace EF6CodeFirstDemo.DbContexts
{
    public abstract class BaseDataContext : DbContext, IBaseDataContext
    {
        public BaseDataContext(string context) : base(context) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).;


            modelBuilder.Entity<Teacher>()
                .ToTable("TeacherInfo");

            modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();
        }
    }
}
