using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public static class XmlSerializer
    {
        public static SerializationResult Serialize<T>(T objectToSerialize, string pathToSave)
        {
            try
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(objectToSerialize.GetType());
                FileStream fs = new FileStream(pathToSave, FileMode.Create);
                serializer.Serialize(fs, objectToSerialize);
                fs.Close();
            }           
            catch(Exception ex)
            {
                return new SerializationResult(false, ex.Message);
            }
            return new SerializationResult(true, string.Empty);
        }

        public class SerializationResult
        {
            public bool Succeded { get; private set; }

            /// <summary>
            /// Reason Will be empty if Succeded = true;
            /// </summary>
            public string Reason { get; private set; }

            public SerializationResult(bool succeded,string reason)
            {
                Succeded = succeded;
                Reason = reason;
            }
        }               
    }
}
