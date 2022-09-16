using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task91522.Models.Abstract;

namespace Task91522.Business.Services.Base
{
    internal class XmlReaderService : IReaderService
    {
        Task<IList<IShape>> IReaderService.Read(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
