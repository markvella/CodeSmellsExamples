using System;
using System.Collections.Generic;
using System.Text;

namespace RefusedBequest
{
    public class FileObject
    {
        public string FileName { get; set; }
        public virtual void Serialize()
        {
            //save to disk
        }
    }

    public class DatabaseFile : FileObject
    {
        public override void Serialize()
        {
            throw new Exception("This object doesn't need serialization");
        }
    }
}
