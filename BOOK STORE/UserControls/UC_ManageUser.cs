using BOOK_STORE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK_STORE.UserControls
{
    public partial class UC_ManageUser : UserControl
    {
        public UC_ManageUser()
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
            dataGridViewManageUser.CellClick += DataGridViewManageUser_CellClick;
            buttonClear.Click += ButtonClear_Click;
           

            ClearAll();
            ListData();
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DataGridViewManageUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.UC_ManageUser_Service();
            var id = dataGridViewManageUser.CurrentRow.Cells[0].Value.ToString().Trim();

            var List = Data.ListAllData().Where(x => x.User_Id == (id)).ToList();

            foreach (var item in List)
            {
                textBoxUserId.Text = item.User_Id.ToString();
                textBoxFullName.Text = item.Full_Name;
                textBoxPhone.Text = item.Phone.ToString();
                textBoxNIC.Text = item.NIC.ToString();
                textBoxEmail.Text = item.Email;
                textBoxPassword.Text = item.Password;
                textBoxUserName.Text = item.User_Name;
                comboBoxRole.Text = item.Role;

            }
            buttonSave.Text = "Update";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text=="Save")
            {
                UC_ManageUser_Service _Col = new UC_ManageUser_Service();
                _Col.AddData(textBoxUserId.Text, textBoxFullName.Text, textBoxPhone.Text, textBoxNIC.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxUserName.Text, comboBoxRole.Text);

                MessageBox.Show("Data Succesfully Saved");

                ClearAll();
                ListData();
            }
            else
            {
                var data = new UC_ManageUser_Service();
                data.UpdateData(textBoxUserId.Text, textBoxFullName.Text, textBoxPhone.Text, textBoxNIC.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxUserName.Text, comboBoxRole.Text);

                MessageBox.Show("Data Succesfully Update");
            }
      
        }


        void ClearAll()
        {
            textBoxUserId.Clear();
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxNIC.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxUserName.Clear();
            textBoxUserId.Select();

            
        }

        void ListData()
        {
            UC_ManageUser_Service Data = new UC_ManageUser_Service();
            dataGridViewManageUser.DataSource = Data.ListAllData().Select(x => new { x.User_Id, x.Full_Name, x.Phone, x.NIC, x.Email, x.Password, x.User_Name, x.Role }).ToList();

        }

        private void dataGridViewManageUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_ManageUser_Load(object sender, EventArgs e)
        {

        }
    }
}
