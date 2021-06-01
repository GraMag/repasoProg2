using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Files.Text
{
    public class Text<T> : IFile<T>
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
