using EF6CodeFirstDemo.Entities;
using System;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contextFactory = new DbContextFactory();

            using (var context = contextFactory.ResolveDbContext(DbTypes.MySql))
            {
                var student = new Student
                {
                    Weight = 75,
                    StudentName = "Aruna Perera"
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}