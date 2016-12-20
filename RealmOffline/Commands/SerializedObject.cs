using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace RealmOffline.Commands
{
    public static  class SerializedObject
    {
        /// <summary>
        ///     Serializes the given obj into XML and saves it to the given XML File path
        /// </summary>
        /// <typeparam name="T">The Type of the obj that will be passed</typeparam>
        /// <param name="obj">The obj of Type <typeparamref name="T" /> that will be serialized</param>
        /// <param name="xmlFilePath">
        ///     The either relative or absolute path to the XML file which the
        ///     <paramref name="obj" /> object should be saved to
        /// </param>
        public static void Serialize<T>(T obj, string xmlFilePath)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath))
                throw new ArgumentNullException("xmlFilePath", "The given XML Path must be not null or empty.");

            try
            {
                using (var writeFileStream = new StreamWriter(xmlFilePath, false))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writeFileStream, obj);
                }
            }
            catch (Exception)
            {
                // TODO: Handle the exceptions if necessary
            }
        }

        /// <summary>
        ///     Deserializes the given XML into a obj of type <typeparamref name="T" />
        /// </summary>
        /// <typeparam name="T">The target type that will be used for the deserialization</typeparam>
        /// <param name="xmlFilePath">The raw XML Content</param>
        /// <returns>A obj of type T</returns>
        public static T Deserialize<T>(string xmlFilePath)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath))
                throw new ArgumentNullException("xmlFilePath", "The given XML Path must be not null or empty.");

            try
            {
                using (var reader = XmlReader.Create(xmlFilePath))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    var obj = (T)serializer.Deserialize(reader);
                    return obj;
                }
            }
            catch (Exception)
            {
                // TODO: Handle the exceptions if necessary
                return default(T);
            }
        }
    }
}
