using System;
using System.IO;

namespace Serialization
{
    class Program//V3
    {
        static void Main()
        {
            var student = new Student();
            using (var streamReader = new StreamReader("Students.txt"))
            {
                student.FirstName = streamReader.ReadLine();
                student.LastName = streamReader.ReadLine();
            }

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }
    }
}
