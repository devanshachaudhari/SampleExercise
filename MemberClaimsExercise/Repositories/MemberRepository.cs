using BusinessModels.Csv;
using CsvHelperLib;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class MemberRepository : IRepository<Member>
    {
        private readonly ICsvParserService<Member> _csvParserService;
        public MemberRepository(ICsvParserService<Member> csvParserService)
        {
            _csvParserService = csvParserService;
        }

        public IEnumerable<Member> GetAll()
        {
            return _csvParserService.ReadCsvFileToModel(@"..\CSV\Member.csv");
        }
    }
}
