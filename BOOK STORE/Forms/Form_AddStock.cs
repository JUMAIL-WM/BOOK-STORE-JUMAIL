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

namespace BOOK_STORE.Forms
{
    public partial class Form_AddStock : Form
    {
        public Form_AddStock()
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
            buttonClear.Click += ButtonClear_Click;
            dataGridViewAddStock.CellClick += DataGridViewAddStock_CellClick;
            buttonClose.Click += ButtonClose_Click;

            ListData();
            ClearAll();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewAddStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.Add_Stock_Service();
            var id = dataGridViewAddStock.CurrentRow.Cells[0].Value.ToString().Trim();

            var List = Data.ListAllData().Where(x => x.Tracking_ID == (id)).ToList();

            foreach (var item in List)
            {
                textBoxTrackingID.Text = item.Tracking_ID.ToString();
                textBoxExistingStock.Text = item.Existing_Stock;
                textBoxNewStock.Text = item.New_Stock;
                textBoxTotalStock.Text = item.Total_Stock;
                textBoxCost.Text = item.Cost;
                textBoxSellingPrice.Text = item.Selling_Price;

            }
            buttonSave.Text = "update";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text.Trim()=="SAVE")
            {
                Add_Stock_Service _Col = new Add_Stock_Service(); //save button
                _Col.AddData(textBoxTrackingID.Text, textBoxExistingStock.Text, textBoxNewStock.Text, textBoxTotalStock.Text, textBoxCost.Text, textBoxSellingPrice.Text);

                MessageBox.Show("Data Succesfully Saved");
                ClearAll();
                ListData();
            }
            else
            {
                var data = new Add_Stock_Service();
                data.UpdateData(textBoxTrackingID.Text, textBoxExistingStock.Text, textBoxNewStock.Text, textBoxTotalStock.Text, textBoxCost.Text, textBoxSellingPrice.Text);

                MessageBox.Show("Data Succesfully Update");
            }
            
  
        }


        void ClearAll()
        {
            textBoxTrackingID.Clear();
            textBoxExistingStock.Clear();
            textBoxNewStock.Clear();
            textBoxTotalStock.Clear();
            textBoxCost.Clear();
            textBoxSellingPrice.Clear();
            textBoxTrackingID.Select();

           
        }

        void ListData()
        {
            Add_Stock_Service Data = new Add_Stock_Service();
            dataGridViewAddStock.DataSource = Data.ListAllData().Select(x => new { x.Tracking_ID, x.Existing_Stock, x.New_Stock, x.Total_Stock, x.Cost, x.Selling_Price }).ToList();

        }

    }
}
