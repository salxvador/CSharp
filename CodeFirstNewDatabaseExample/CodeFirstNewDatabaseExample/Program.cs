using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the student's first name:");
                var fn = Console.ReadLine();
                Console.WriteLine("Enter the student's last name:");
                var ln = Console.ReadLine();

                var student = new Student { FirstName = fn, LastName = ln };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.LastName
                            select s;

                foreach (var stu in query)
                {
                    Console.WriteLine("#{0}, {1} {2}", stu.Id, stu.FirstName, stu.LastName);
                }
                Console.Read();
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
