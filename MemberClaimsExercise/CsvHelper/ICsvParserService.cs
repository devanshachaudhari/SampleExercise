using System;
using System.Collections.Generic;
using System.Text;

namespace CsvHelperLib
{
    public interface ICsvParserService<T> where T:class
    {
        List<T> ReadCsvFileToModel(string path);
    }
}
