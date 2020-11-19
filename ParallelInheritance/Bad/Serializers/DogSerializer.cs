using Newtonsoft.Json;
using ParallelInheritance.Bad.Animals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ParallelInheritance.Bad.Serializers
{
    public class DogSerializer
    {
        private readonly Dog _dog;

        public DogSerializer(Dog dog)
        {
            _dog = dog;
        }

        public string Serialize()
        {
            var serializer = new XmlSerializer(typeof(Dog));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms,_dog);
                return UTF8Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
