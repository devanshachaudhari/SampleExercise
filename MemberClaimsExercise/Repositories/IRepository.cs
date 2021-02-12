using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
