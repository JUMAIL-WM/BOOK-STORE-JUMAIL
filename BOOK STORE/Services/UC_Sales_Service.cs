using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class UC_Sales_Service
    {
        Repository _Repo;

        public UC_Sales_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<UC_Sales_Table> ListAllData()
        {
            return _Repo.GetAll<UC_Sales_Table>().ToList();
        }

        public void AddData(string Bar_Cade, string Book_Title, string Publisher, string Price, string Tracking_ID, string Author, string Discount)
        {
            var mydata = new UC_Sales_Table
            {
                Tracking_ID = Tracking_ID,
                Bar_Code = Bar_Cade,
                Book_Title = Book_Title,
                Publisher = Publisher,
                Price = Price,
                Author = Author,
                Discount = Discount
            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string Bar_Cade, string Book_Title, string Publisher, string Price, string Tracking_ID, string Author, string Discount)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.Bar_Code.Trim() == Bar_Cade.Trim());

            Qu.Bar_Code = Bar_Cade;
            Qu.Book_Title = Book_Title;
            Qu.Publisher = Publisher;
            Qu.Price = Price;
            Qu.Tracking_ID = Tracking_ID;
            Qu.Author = Author;
            Qu.Discount = Discount;

            _Repo.UpdateData(Qu);
        }


        public void DeleteData(string Bar_Code)
        {
            var qu = _Repo.GetAll<UC_Sales_Table>().Where(x => x.Bar_Code == Bar_Code).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }
    }
}
