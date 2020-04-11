using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Novanda", 19);
            person.GetNameAndAge();
            Console.WriteLine();
            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();
            Console.WriteLine();
            Student student = new Student("Novanda", 19, "19.11.2695", "novanda.praditya@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}