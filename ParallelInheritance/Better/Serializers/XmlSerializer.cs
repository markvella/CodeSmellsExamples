using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ParallelInheritance.Better.Serializers
{
    public class XmlSerializer<T>
    {
        public XmlSerializer(T value)
        {
            Value = value;
        }

        public string Serialize()
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, Value);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public T Value { get; private set; }
    }
}
