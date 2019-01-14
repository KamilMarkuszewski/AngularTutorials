using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            AddStudentsSeedIfNeeded();

            ShowAllStudents();

            ClearStudentsTable();

            ShowAllStudents();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void ClearStudentsTable()
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                var students = context.Students.ToArray();

                foreach (var objectToDelete in students)
                {
                    context.Students.Remove(objectToDelete);
                }
                context.SaveChanges();
            }
        }

        private static void ShowAllStudents()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Students: ");
            using (CoreDbContext context = new CoreDbContext())
            {
                foreach (var student in context.Students)
                {
                    Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
                }
            }
            Console.WriteLine("------------");
        }

        private static void AddStudentsSeedIfNeeded()
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                if (!context.Students.Any())
                {
                    var student = new Student()
                    {
                        FirstName = "Kamil",
                        LastName = "Markuszewski",
                        EnrollmentDate = new DateTime(2019, 1, 14)
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                }
            }
        }

    }
}
