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
    public partial class Form_AddNewBook : Form
    {
        public Form_AddNewBook()
        {
            InitializeComponent();
            buttonClear.Click += ButtonClear_Click;
            buttonClose.Click += ButtonClose_Click;
            buttonAdd.Click += ButtonAdd_Click;
            dataGridViewAddNewBook.CellClick += DataGridViewAddNewBook_CellClick;
            buttonSave.Click += ButtonSave_Click;
            buttonOff.Click += ButtonOff_Click;

            ListData();
            ClearAll();
            SetMyCoustomEormat();

        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text.Trim() == "SAVE")
            {
                Add_NewBook_Service _Col = new Add_NewBook_Service();
                _Col.AddData(textBoxTrackingID.Text, comboBoxAuthor.Text, comboBoxPublisher.Text, comboBoxCategory.Text, textBoxSellingPrice.Text, TextBoxRemarks.Text, textBoxBookTitle.Text, dateTimePicker1.Value, textBoxCostPrice.Text, textBoxBarCode.Text);

                MessageBox.Show("Data Succesfully Saved");
                ClearAll();
                ListData();
            }
            else
            {
                var data = new Add_NewBook_Service();
                data.UpdateData(textBoxTrackingID.Text, comboBoxAuthor.Text, comboBoxPublisher.Text, comboBoxCategory.Text, textBoxSellingPrice.Text, TextBoxRemarks.Text, textBoxBookTitle.Text, dateTimePicker1.Value, textBoxCostPrice.Text, textBoxBarCode.Text);

                MessageBox.Show("Data Succesfully Update");
            }
          
        }

        private void DataGridViewAddNewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Data = new Services.Add_NewBook_Service();
            var id = dataGridViewAddNewBook.CurrentRow.Cells[0].Value.ToString().Trim();

            var List = Data.ListAllData().Where(x => x.Tracking_ID == (id)).ToList();

            foreach (var item in List)
            {
                textBoxTrackingID.Text = item.Tracking_ID.ToString();
                comboBoxAuthor.Text = item.Author;
                comboBoxPublisher.Text = item.Publisher;
                comboBoxCategory.Text = item.Category;
                textBoxSellingPrice.Text = item.Selling_Price.ToString();
                TextBoxRemarks.Text = item.Remarks;
                textBoxBookTitle.Text = item.Book_Title;
                DateTime? date = item.Date;
                textBoxCostPrice.Text = item.Cost_Price.ToString();
                textBoxBarCode.Text = item.Bar_Code.ToString();

            }
            buttonSave.Text = "update";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ac = new Form_AddCategory())
            {
                ac.ShowDialog();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        void ClearAll()
        {
            textBoxTrackingID.Clear();
            /*comboBoxAuthor.Items.Clear();
            comboBoxPublisher.Items.Clear();
            comboBoxCategory.Items.Clear();*/
            textBoxSellingPrice.Clear();
            TextBoxRemarks.Clear();
            textBoxBookTitle.Clear();
            textBoxCostPrice.Clear();
            textBoxBarCode.Clear();
            textBoxTrackingID.Select();

            
        }

        void ListData()
        {
            Add_NewBook_Service Data = new Add_NewBook_Service();
            dataGridViewAddNewBook.DataSource = Data.ListAllData().Select(x => new { x.Tracking_ID, x.Author, x.Publisher, x.Category, x.Selling_Price, x.Remarks, x.Book_Title, x.Date, x.Cost_Price, x.Bar_Code }).ToList();

        }

        public void SetMyCoustomEormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd"; 
        }

    }
}
