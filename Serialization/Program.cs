using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program//V7
    {
        private const string Filepath = "Students.txt";
        static void Main()
        {
            var unitInput = new Unit {Id = 100500};
            unitInput.Add(new Item { Key = 1, Value = 10 });
            unitInput.Add(new Item { Key = 2, Value = "ten" });
            unitInput.Add(new Item { Key = 3, Value = 10.5 });

            SerializeXml(unitInput);

            var unitOutput = DeserializeXml<Unit>();

            Console.WriteLine($"{unitOutput}");
            Console.ReadKey();
        }

        private static void SerializeXml<T>(T item)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var streamWriter = new StreamWriter(Filepath))
            {
                serializer.Serialize(streamWriter, item);
            }
        }

        private static T DeserializeXml<T>() where T: class 
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var streamReader = new StreamReader(Filepath))
            {
                if (serializer.Deserialize(streamReader) is T result)
                {
                    return result;
                }
            }

            return null;
        }

        private static void SerializeCSV<T>(T item)
        {
      //some changes
        }
    }
}
