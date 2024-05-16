using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab3
{
    internal static class Serializer
    {
        public static void BinarySerialize(Graph graph, string fileName)
        {
            Stream stream = new FileStream(fileName,FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, graph);
            stream.Close();

            Logger.Print("Сериализация успешно завершениа");
        }

        public static Graph BinaryDeserialize(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Graph graph = formatter.Deserialize(stream) as Graph;
            stream.Close();

            Logger.Print("Десериализация успешно завершена");

            return graph;
        }

        public static void XMLSerialize(Graph graph, string fileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(Graph));
            Stream stream = new FileStream(fileName, FileMode.Create);
            s.Serialize(stream, graph);
            stream.Close();
            
            Logger.Print("Сериализация успешно завершениа");
        }

        public static Graph XMLDeserialize(string fileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(Graph));
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Graph graph = s.Deserialize(stream) as Graph;
            stream.Close();

            Logger.Print("Десериализация успешно завершена");
            return graph;

        }
    }
}
