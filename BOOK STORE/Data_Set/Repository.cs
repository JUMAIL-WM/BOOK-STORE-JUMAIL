using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Data_Set
{
    public class Repository : IRepository
    {

        private Jumail_ProjectEntities _obj;

        public Repository()
        {
            _obj = new Jumail_ProjectEntities();
        }


        public void AddData<T>(T Entry) where T : class
        {
            _obj.Entry(Entry).State = EntityState.Added;
            _obj.SaveChanges();
            _obj.Entry(Entry).State = EntityState.Detached;
        }

        public void DeleteData<T>(T Entry) where T : class
        {
            _obj.Entry(Entry).State = EntityState.Deleted;
            _obj.SaveChanges();
            _obj.Entry(Entry).State = EntityState.Detached;
        }

        public void Dispose()
        {
            _obj.Dispose();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _obj.Set<T>();
        }

        public void UpdateData<T>(T Entry) where T : class
        {
            _obj.Entry(Entry).State = EntityState.Modified;
            _obj.SaveChanges();
            _obj.Entry(Entry).State = EntityState.Detached;
        }
    }
}
