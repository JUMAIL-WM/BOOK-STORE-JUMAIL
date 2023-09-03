using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Data_Set
{
    public interface IRepository : IDisposable
    {
        IEnumerable<T> GetAll<T>() where T : class;

        void AddData<T>(T Entry) where T : class;

        void UpdateData<T>(T Entry) where T : class;

        void DeleteData<T>(T Entry) where T : class;
    }
}

