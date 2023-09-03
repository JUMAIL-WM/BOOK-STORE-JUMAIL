using BOOK_STORE.Data_Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_STORE.Services
{
    public class UC_ManageUser_Service
    {
        Repository _Repo;

        public UC_ManageUser_Service()
        {
            _Repo = new Repository();
        }

        public IEnumerable<UC_ManageUser_Table> ListAllData()
        {
            return _Repo.GetAll<UC_ManageUser_Table>().ToList();
        }

        public void AddData(string User_Id, string Full_Name, string Phone, string NIC, string Email, string Password, string User_Name, string Role)
        {
            var mydata = new UC_ManageUser_Table
            {

                User_Id = User_Id,
                Full_Name = Full_Name,
                Phone = Phone,
                NIC = NIC,
                Email = Email,
                Password = Password,
                User_Name = User_Name,
                Role = Role
              

            };

            _Repo.AddData(mydata);
        }

        public void UpdateData(string User_Id, string Full_Name, string Phone, string NIC, string Email, string Password, string User_Name, string Role)
        {
            var Qu = ListAllData().SingleOrDefault(x => x.User_Id == User_Id);

            Qu.User_Id = User_Id;
            Qu.Full_Name = Full_Name;
            Qu.Phone = Phone;
            Qu.NIC = NIC;
            Qu.Email = Email;
            Qu.Password = Password;
            Qu.User_Name = User_Name;
            Qu.Role = Role;
      

            _Repo.UpdateData(Qu);
        }

        public void DeleteData(string User_Id)
        {
            var qu = _Repo.GetAll<UC_ManageUser_Table>().Where(x => x.User_Id == User_Id).ToList();

            foreach (var item in qu)
            {
                _Repo.DeleteData(item);
            }

        }

        internal void AddData(int v, string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }
    }
}
