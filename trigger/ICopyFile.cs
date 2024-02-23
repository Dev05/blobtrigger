using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trigger
{
    public interface ICopyFile
    {
        void FileCopyFunction(Stream input, Stream output);
        
    }
}
