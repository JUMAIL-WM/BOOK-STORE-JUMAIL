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
    public partial class Form_AddExpense : Form
    {
        public Form_AddExpense()
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
            buttonClear.Click += ButtonClear_Click;
            buttonClose.Click += ButtonClose_Click;

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text.Trim()=="SAVE")
            {
                UC_ManageExpence_Service _Col = new UC_ManageExpence_Service(); //save button
                _Col.AddData(textBoxExpenseTitle.Text, textBoxAmount.Text, TextBoxDescription.Text);

                MessageBox.Show("Data Succesfully Saved");
                ClearAll();
                ListData();
            }
            else
            {
                var data = new UC_ManageExpence_Service();
                //data.UpdateData(textBoxExpenseTitle.Text, textBoxAmount.Text, TextBoxDescription.Text);

                MessageBox.Show("Data Succesfully Update");
            }
         
        }

        void ListData()
        {
          

        }

        void ClearAll()
        {
            textBoxExpenseTitle.Clear();
            textBoxAmount.Clear();
            TextBoxDescription.Clear();

        }
    }
}
