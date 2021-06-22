using System;
using System.IO;

namespace Serialization
{
    class Program//V2
    {
        static void Main()
        {
            var student = new Student();
            Console.Write("Enter name of student:");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter last name of student:");
            student.LastName = Console.ReadLine();

            var streamWriter = new StreamWriter("Students.txt");
            streamWriter.WriteLine($"{student.FirstName}{Environment.NewLine}{student.LastName}{Environment.NewLine}");
            streamWriter.Close();

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }
    }
}
