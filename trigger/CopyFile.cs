using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace trigger
{
    public class CopyFile : ICopyFile
    {
        public void FileCopyFunction(Stream input, Stream output)
        {
           //do some operation
           input.CopyTo(output);
        }
    }
}
