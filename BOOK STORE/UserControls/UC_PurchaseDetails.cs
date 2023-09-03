using BOOK_STORE.Forms;
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
    public partial class UC_PurchaseDetails : UserControl
    {
        public UC_PurchaseDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }*/

        /*private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddStock ads = new Form_AddStock())
            {
                ads.ShowDialog();
            }
        }*/

        private void btnAddNewBooks_Click_1(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (Form_AddStock ads = new Form_AddStock())
            {
                ads.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
