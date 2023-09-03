using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class UC_ManageExpence_Service
    {
        Repository _Repo;

        public UC_ManageExpence_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<UC_ManageExpence_Table> ListAllData()
        {
            return _Repo.GetAll<UC_ManageExpence_Table>().ToList();
        }

        public void AddData(string Expence_Title, string Amount, string Description)
        {
            var mydata = new UC_ManageExpence_Table
            {              
                Expence_Title= Expence_Title,
                Amount = Amount,
                Description = Description
                        
            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(int ID, string Expence_Title, string Amount, string Description)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.ID == ID);

            Qu.ID = ID;
            Qu.Expence_Title = Expence_Title;
            Qu.Amount = Amount;
            Qu.Description = Description;
    
            _Repo.UpdateData(Qu);
        }


        public void DeleteData(int ID)
        {
            var qu = _Repo.GetAll<UC_ManageExpence_Table>().Where(x => x.ID == ID).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }
    }
}
