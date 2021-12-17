using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace DataSerializerLib
{
    static public class DataSerializer
    {
        public static void BinarySerialize(object obj, string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                binaryFormatter.Serialize(fs, obj);
                fs.Close();
            }
        }

        public static object BinaryDeserialize(string path)
        {
            object obj = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                obj = binaryFormatter.Deserialize(fs);
                fs.Close();
            }
            return obj;
        }

        public static void XMLSerialize(Type objType, object obj, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(objType);
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, obj);
                sw.Close();
            }
        }

        public static object XMLDeserialize(Type objType, string path)
        {
            object obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(objType);
            using (StreamReader sr = new StreamReader(path))
            {
                obj = xmlSerializer.Deserialize(sr);
                sr.Close();
            }
            return obj;
        }

        public static void JSONSerialize(object obj, string path)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (JsonTextWriter jsonWriter = new JsonTextWriter(new StreamWriter(path)))
            {
                jsonSerializer.Serialize(jsonWriter, obj);
                jsonWriter.Close();
            }
        }

        public static object JSONDeserialize(Type objType, string path)
        {
            object obj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (JsonReader jsonReader = new JsonTextReader(new StreamReader(path)))
            {
                obj = jsonSerializer.Deserialize(jsonReader, objType);
                jsonReader.Close();
            }
            return obj;
        }


        public static void SoapSerialize(object obj, string path)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                soapFormatter.Serialize(fs, obj);
                fs.Close();
            }
        }

        public static object SoapDeserialize(string path)
        {
            object obj = null;
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                obj = soapFormatter.Deserialize(fs);
                fs.Close();
            }
            return obj;
        }

    }
}
