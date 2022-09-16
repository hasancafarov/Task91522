using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task91522.Business.Services;
using Task91522.Models.Abstract;
using Task91522.Models.Enums;

namespace Task91522.Business
{
    internal static class ReadData
    {
        internal static async Task<IList<IShape>> Read(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            if (Path.GetExtension(filePath) == "." + Enum.GetName(FileType.json))
            {
                var readService = new ReadService(new JsonReaderService());
                return await readService.ReadFile(filePath);
            }

            throw new NotImplementedException();
        }
    }
}
