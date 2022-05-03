using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace From_JSON_to_XML
{
    public static class Converter
    {
        public static void ConvertToXML(List<Post> posts)
        {
            using (var file = new FileStream("posts.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Post>));
                xmlSerializer.Serialize(file, posts);
            }
        }
    }
}
