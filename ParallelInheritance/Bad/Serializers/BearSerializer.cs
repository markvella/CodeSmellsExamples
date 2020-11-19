using Newtonsoft.Json;
using ParallelInheritance.Bad.Animals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ParallelInheritance.Bad.Serializers
{
    public class BearSerializer
    {
        private readonly Bear _bear;

        public BearSerializer(Bear bear)
        {
            _bear = bear;
        }

        public string Serialize()
        {
            var serializer = new XmlSerializer(typeof(Bear));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, _bear);
                return UTF8Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
