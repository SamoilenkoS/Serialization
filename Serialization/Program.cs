using System;
using System.IO;
using System.Xml.Serialization;

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

            SerializeXML(student);

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }

        private static void SerializeXML(Student student)
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamWritter = new StreamWriter("Students.txt"))
            {
                serializer.Serialize(streamWritter, student);
            }
        }
    }
}
