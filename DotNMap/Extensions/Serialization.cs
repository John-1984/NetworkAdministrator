using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DotNMap.Extensions{
    public static class Serialization{
        public static T Deserialize<T>(string xml){
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xml))){
                return deserialize<T>(stream);
            }
        }

        public static T DeserializeFromFile<T>(string filePath){
            using (StreamReader stream = new StreamReader(filePath)){
                T result = (T)new XmlSerializer(typeof(T)).Deserialize(stream);
                return result;
            }
        }

        public static string Serialize<T>(this T item){
            return serialize(item);
        }

        public static void SerializeToFile<T>(this T item, string filePath){
            string result = serialize(item);
            File.WriteAllText(filePath, result);
        }

        private static T deserialize<T>(Stream stream){
            T result = (T)new XmlSerializer(typeof(T)).Deserialize(stream);
            return result;
        }

        private static string serialize<T>(T item){
            MemoryStream stream = new MemoryStream();
            using (XmlTextWriter xmlWriter = new XmlTextWriter(stream, Encoding.UTF8)){
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(xmlWriter, item);
                stream = (MemoryStream)xmlWriter.BaseStream;
            }
            string result = new UTF8Encoding().GetString(stream.ToArray());
            stream.Dispose();
            return result;
        }
    }
}