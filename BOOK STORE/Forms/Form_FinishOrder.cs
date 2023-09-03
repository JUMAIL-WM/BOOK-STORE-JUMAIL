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

namespace BOOK_STORE.Forms
{
    public partial class Form_FinishOrder : Form
    {
        public Form_FinishOrder()
        {
            InitializeComponent();
            buttonDone.Click += ButtonDone_Click;
            buttonClose.Click += ButtonClose_Click;
            dataGridViewFinishOrder.CellClick += DataGridViewFinishOrder_CellClick;
            buttonClear.Click += ButtonClear_Click;
            buttonReport.Click += ButtonReport_Click;

            ClearAll();
            ListData();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            Report_Form frm = new Report_Form();
            frm.ShowDialog();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DataGridViewFinishOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.Finish_Order_Service();
            var id = dataGridViewFinishOrder.CurrentRow.Cells[0].Value.ToString().Trim();

            var List = Data.ListAllData().Where(x => x.ID == (id)).ToList();

            foreach (var item in List)
            {
                textBoxNetAmount.Text = item.Net_Amount.ToString();
                textBoxDiscount.Text = item.Discount.ToString();
                textBoxTotalAmount.Text = item.Total_Amount.ToString();
                textBoxPaidAmount.Text = item.Paid_Amount.ToString();
                textBoxBalaneAmount.Text = item.Balance_Amount.ToString();

            }
            buttonDone.Text = "update";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            if (buttonDone.Text.Trim()=="DONE")
            {
                Finish_Order_Service _Col = new Finish_Order_Service(); //save button
                _Col.AddData("", textBoxNetAmount.Text, textBoxDiscount.Text, textBoxTotalAmount.Text, textBoxPaidAmount.Text, textBoxBalaneAmount.Text);

                MessageBox.Show("Data Succesfully Saved");
                ClearAll();
                ListData();
            }
            else
            {
                var data = new Finish_Order_Service();
                data.UpdateData("", textBoxNetAmount.Text, textBoxDiscount.Text, textBoxTotalAmount.Text, textBoxPaidAmount.Text, textBoxBalaneAmount.Text);

                MessageBox.Show("Data Succesfully Update");
            }
      
        }


        void ClearAll()
        {
            textBoxNetAmount.Clear();
            textBoxDiscount.Clear();
            textBoxTotalAmount.Clear();
            textBoxPaidAmount.Clear();
            textBoxBalaneAmount.Clear();
            
            textBoxNetAmount.Select();

        }

        void ListData()
        {
            var Data = new Finish_Order_Service();
            dataGridViewFinishOrder.DataSource = Data.ListAllData().Select(x => new { x.ID, x.Net_Amount, x.Discount, x.Total_Amount, x.Paid_Amount }).ToList();

        }

    }
}
