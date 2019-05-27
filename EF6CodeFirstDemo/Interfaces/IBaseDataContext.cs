using EF6CodeFirstDemo.Entities;
using System.Data.Entity;

namespace EF6CodeFirstDemo.Interfaces
{
    public interface IBaseDataContext
    {
       DbSet<Student> Students { get; set; }
       DbSet<Grade> Grades { get; set; }
       DbSet<Course> Courses { get; set; }
       DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
