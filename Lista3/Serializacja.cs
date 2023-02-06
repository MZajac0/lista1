using System.IO;
using System.Xml.Serialization;

namespace Lista3
{
    public class Serializacja
    {
        public static ds Deserializacja<ds>(string droga) where ds : class
        {
            XmlSerializer xmlSerializacja = new XmlSerializer(typeof(ds));
            using (StreamReader sr = new StreamReader(droga))
            {
                return (ds)xmlSerializacja.Deserialize(sr);
            }
        }
        public static void SerializacjaToXML<ds>(ds obj, string R)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (StreamWriter sw = new StreamWriter(R))
            {
                xmlSerializer.Serialize(sw, obj);
            }
        }
    }
}
