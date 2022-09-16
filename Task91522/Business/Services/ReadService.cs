using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task91522.Business.Services.Base;
using Task91522.Models.Abstract;

namespace Task91522.Business.Services
{
    public class ReadService
    {
        private readonly IReaderService _readerService;

        internal ReadService(IReaderService readerService)
        {
            _readerService = readerService;
        }

        public async Task<IList<IShape>> ReadFile(string filePath)
        {
            return await _readerService.Read(filePath);
        }
    }
}
