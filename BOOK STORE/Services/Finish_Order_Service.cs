using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class Finish_Order_Service
    {
        Repository _Repo;

        public Finish_Order_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Finish_Order_Table> ListAllData()
        {
            return _Repo.GetAll<Finish_Order_Table>().ToList();
        }

        public void AddData(string ID, string Net_Amount, string Discount, string Total_Amount, string Paid_Amount, string Balance_Amount)
        {
            var mydata = new Finish_Order_Table
            {
               ID= ID,
               Net_Amount= Net_Amount,
               Discount= Discount,
               Total_Amount= Total_Amount,
               Paid_Amount= Paid_Amount,
               Balance_Amount= Balance_Amount
            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string ID, string Net_Amount, string Discount, string Total_Amount, string Paid_Amount, string Balance_Amount)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.ID.Trim() == ID.Trim());

            Qu.ID = ID;
            Qu.Net_Amount = Net_Amount;
            Qu.Discount = Discount;
            Qu.Total_Amount = Total_Amount;
            Qu.Paid_Amount= Paid_Amount;
            Qu.Balance_Amount= Balance_Amount;
         

            _Repo.UpdateData(Qu);
        }


        public void DeleteData(String ID)
        {
            var qu = _Repo.GetAll<Finish_Order_Table>().Where(x => x.ID == ID).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }

 
    }
}
