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

namespace BOOK_STORE.UserControls
{
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
        {
            InitializeComponent();
            buttonFinish.Click += ButtonFinish_Click;
            buttonAddCard.Click += ButtonAddCard_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;

            ClearAll();
            ListData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.UC_Sales_Service();
            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();

            var List = Data.ListAllData().Where(x => x.Bar_Code == (id)).ToList();

            foreach (var item in List)
            {
                textBoxBarCode.Text = item.Bar_Code.ToString();
                textBoxBookTitle.Text = item.Book_Title.ToString();
                textBoxPublisher.Text = item.Publisher.ToString();
                textBoxPrice.Text = item.Price.ToString();
                textBoxTrackingID.Text = item.Tracking_ID.ToString();
                textBoxAuthor.Text = item.Author.ToString();
                textBoxDiscount.Text = item.Discount.ToString();
                
            }
            buttonAddCard.Text = "Update";
        }

        private void ButtonAddCard_Click(object sender, EventArgs e)
        {
            if (buttonAddCard.Text.Trim()== "ADD TO CART")
            {
                UC_Sales_Service _Col = new UC_Sales_Service(); //save button
                _Col.AddData(textBoxBarCode.Text, textBoxBookTitle.Text, textBoxPublisher.Text, textBoxPrice.Text, textBoxTrackingID.Text, textBoxAuthor.Text, textBoxDiscount.Text);

                MessageBox.Show("Data Succesfully Saved");
                ClearAll();
                ListData();
            }
            else
            {
                var data = new UC_Sales_Service();
                data.UpdateData(textBoxBarCode.Text, textBoxBookTitle.Text, textBoxPublisher.Text, textBoxPrice.Text, textBoxTrackingID.Text, textBoxAuthor.Text, textBoxDiscount.Text);

                MessageBox.Show("Data Succesfully Update");
            }
     
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            using (Form_FinishOrder uf = new Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }

        void ClearAll()
        {
            textBoxBarCode.Clear();
            textBoxBookTitle.Clear();
            textBoxPublisher.Clear();
            textBoxPrice.Clear();
            textBoxTrackingID.Clear();
            textBoxAuthor.Clear();
            textBoxDiscount.Clear();
            textBoxBarCode.Select();

        }

        void ListData()
        {
            UC_Sales_Service Data = new UC_Sales_Service();
            dataGridView1.DataSource = Data.ListAllData().Select(x => new { x.Bar_Code, x.Book_Title, x.Publisher, x.Price, x.Tracking_ID, x.Author, x.Discount }).ToList();

        }

    }
}
