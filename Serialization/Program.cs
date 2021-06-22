using System;

namespace Serialization
{
    class Program//V1
    {
        static void Main()
        {
            var student = new Student();
            Console.Write("Enter name of student:");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter last name of student:");
            student.LastName = Console.ReadLine();

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }
    }
}
