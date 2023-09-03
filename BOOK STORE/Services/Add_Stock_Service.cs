using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class Add_Stock_Service
    {
        Repository _Repo;

        public Add_Stock_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Add_Stock_Table> ListAllData()
        {
            return _Repo.GetAll<Add_Stock_Table>().ToList();
        }

        public void AddData(string Tracking_ID, string Existing_Stock, string New_Stock, string Total_Stock, string Cost, string Selling_Price)
        {
            var mydata = new Add_Stock_Table
            {
                Tracking_ID = Tracking_ID,
                Existing_Stock = Existing_Stock,
                New_Stock= New_Stock,
                Total_Stock = Total_Stock,
                Cost = Cost,
                Selling_Price= Selling_Price    
            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string Tracking_ID, string Existing_Stock, string New_Stock, string Total_Stock, string Cost, string Selling_Price)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.Tracking_ID == Tracking_ID);

            Qu.Tracking_ID = Tracking_ID;
            Qu.Existing_Stock = Existing_Stock;
            Qu.New_Stock = New_Stock;
            Qu.Total_Stock = Total_Stock;
            Qu.Cost = Cost;
            Qu.Selling_Price = Selling_Price; 

            _Repo.UpdateData(Qu);
        }


        public void DeleteData(string Tracking_ID)
        {
            var qu = _Repo.GetAll<Add_Stock_Table>().Where(x => x.Tracking_ID == Tracking_ID).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }

      
    }
}
