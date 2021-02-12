using BusinessModels.Csv;
using CsvHelperLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ClaimRepository : IRepository<Claim>
    {
        private readonly ICsvParserService<Claim> _csvParserService;
        public ClaimRepository(ICsvParserService<Claim> csvParserService)
        {
            _csvParserService = csvParserService;
        }

        public IEnumerable<Claim> GetAll()
        {
            return _csvParserService.ReadCsvFileToModel(@"..\CSV\Claim.csv");
        }
    }
}
