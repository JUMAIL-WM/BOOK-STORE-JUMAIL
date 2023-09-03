using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class Login_Service
    {
        Repository _Repo;

        public Login_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Login_Table> ListAllData()
        {
            return _Repo.GetAll<Login_Table>().ToList();
        }

        public void AddData(string Username , string Password)
        {
            var mydata = new Login_Table
            {
                UserName= Username,
                Password= Password
            };

            _Repo.AddData(mydata);
        }

    }
}
