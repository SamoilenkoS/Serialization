using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program//V5
    {
        private const string Filepath = "Students.txt";
        static void Main()
        {
            SerializeXml(new Student
            {
                LastName = "Test",
                FirstName = "Best",
                Age = 5
            });

            var student = DeserializeXml();

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }

        private static void SerializeXml(Student student)
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamWriter = new StreamWriter(Filepath))
            {
                serializer.Serialize(streamWriter, student);
            }
        }

        private static Student DeserializeXml()
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamReader = new StreamReader(Filepath))
            {
                if (serializer.Deserialize(streamReader) is Student result)
                {
                    return result;
                }
            }

            return null;
        }
    }
}
