using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace trigger
{
    [StorageAccount("BlobConnec")]
    public class ImagemoveFunction
    {
        private readonly ICopyFile copyFile;
        public ImagemoveFunction(ICopyFile _copyFile)
        {
            copyFile = _copyFile;
        }
        [FunctionName("ImagemoveFunction")]
        public void Run([BlobTrigger("test/{name}")]Stream input,
            [Blob("test2/{name}", FileAccess.Write)] Stream output,
            string name, ILogger log)
        {
            copyFile.FileCopyFunction(input, output);
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {input.Length} Bytes");
        }
    }
}
