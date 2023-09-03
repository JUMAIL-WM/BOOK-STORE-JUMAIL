using BOOK_STORE.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOOK_STORE.UserControls
{
    public partial class UC_ManageExpense : UserControl
    {
        public UC_ManageExpense()
        {
            InitializeComponent();
            ListData();

           
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.UC_ManageExpence_Service();
            var id = dataGridViewExpense.CurrentRow.Cells[0].Value.ToString();

            var List = Data.ListAllData().Where(x => x.ID == Int32.Parse(id)).ToList();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense ae = new Form_AddExpense())
            {
                ae.ShowDialog();
            }
            ListData();
        }

      

        private void label5_Click(object sender, EventArgs e)
        {
            Add_NewBook_Service _Col = new Add_NewBook_Service(); //save button
           // _Col.AddData();

            MessageBox.Show("Data Succesfully Saved");
            ClearAll();
            ListData();
        }

        void ClearAll()
        {
  

            label5.Text = "Save";
        }

        void ListData()
        {
            var Data = new UC_ManageExpence_Service();
            dataGridViewExpense.DataSource = Data.ListAllData().Select(x => new { x.ID, x.Expence_Title, x.Amount, x.Description }).ToList();

        }
    }
}
