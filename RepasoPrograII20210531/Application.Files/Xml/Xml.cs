using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Files.Xml
{
    public class Xml<T> : IFile<T>
    {
        //TODO implementar IFile
        public bool Read(string file, out T data)
        {
            throw new NotImplementedException();
        }

        public bool Save(string file, T data)
        {
            throw new NotImplementedException();
        }
    }
}
