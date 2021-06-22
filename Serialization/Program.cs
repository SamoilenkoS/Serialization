using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program//V5
    {
        static void Main()
        {
            var student = DeserializeXml();

            Console.WriteLine($"{student}");
            Console.ReadKey();
        }

        private static void SerializeXml(Student student)
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamWriter = new StreamWriter("Students.txt"))
            {
                serializer.Serialize(streamWriter, student);
            }
        }

        private static Student DeserializeXml()
        {
            var serializer = new XmlSerializer(typeof(Student));
            using (var streamReader = new StreamReader("Students.txt"))
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
