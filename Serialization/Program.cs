using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program//V4
    {
        static void Main()
        {
            var student = new Student();
            using (var streamReader = new StreamReader("Students.txt"))
            {
                student.FirstName = streamReader.ReadLine();
                student.LastName = streamReader.ReadLine();
            }

            SerializeXML(student);//eXtensible Markup Language

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }

        private static void SerializeXML(Student student)
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamWriter = new StreamWriter("Students.txt"))
            {
                serializer.Serialize(streamWriter, student);
            }
        }
    }
}
