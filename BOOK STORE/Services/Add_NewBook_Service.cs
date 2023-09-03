using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class Add_NewBook_Service
    {
        Repository _Repo;

        public Add_NewBook_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Add_NewBook_Table> ListAllData()
        {
            return _Repo.GetAll<Add_NewBook_Table>().ToList();
        }

        public void AddData(string Tracking_ID, string Author, string Publisher, string Category, string Selling_Price, string Remarks, string Book_Title, DateTime date, string Cost_Price, string Bar_Code)
        {
            var mydata = new Add_NewBook_Table
            {

                Tracking_ID = Tracking_ID,
                Author = Author,
                Publisher = Publisher,
                Category = Category,
                Selling_Price= Selling_Price,
                Remarks= Remarks,
                Book_Title=Book_Title,
                Date= date,
                Cost_Price=Cost_Price,
                Bar_Code=Bar_Code
    
            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string Tracking_ID, string Author, string Publisher, string Category, string Selling_Price, string Remarks, string Book_Title, DateTime Date, string Cost_Price, string Bar_Code)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.Tracking_ID == Tracking_ID);

            Qu.Tracking_ID = Tracking_ID;
            Qu.Author = Author;
            Qu.Publisher = Publisher;
            Qu.Category = Category;
            Qu.Selling_Price= Selling_Price;
            Qu.Remarks= Remarks;
            Qu.Book_Title=Book_Title;
            Qu.Date = Date;
            Qu.Cost_Price=Cost_Price;
            Qu.Bar_Code=Bar_Code;

            _Repo.UpdateData(Qu);
        }

        public void DeleteData(string Tracking_ID)
        {
            var qu = _Repo.GetAll<Add_NewBook_Table>().Where(x => x.Tracking_ID == Tracking_ID).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }

       
     
    }
}
