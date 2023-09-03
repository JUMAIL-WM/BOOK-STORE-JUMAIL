using BOOK_STORE.Books_Forms;
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
    public partial class UC_Home : UserControl
    {
        

        public UC_Home()
        {
            InitializeComponent();
            
        }

        private void buttongread06_Click(object sender, EventArgs e)
        {
            var frm = new Gr_06_Form();
            FormInPanel(panel2, frm);
            //frm.Show();

        }

        /*private void FormInPanel(Panel panel2, Gr_06_Form frm)
        {
            Gr_06_Form frm = new Gr_06_Form();
            FormInPanel(panel2, frm);
        }
*/
        public void FormInPanel(Panel panel2_Paint, Form frm)
        {
            if (panel2_Paint.Controls.Count > 0)
                panel2_Paint.Controls.RemoveAt(0);

            //panel2_Paint.BackColor = Color.AliceBlue;

            frm.TopLevel = false;
            panel2_Paint.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Location = new Point((panel2_Paint.Width - frm.Width) / 2, (panel2_Paint.Height - frm.Height) / 2);
            panel2_Paint.Tag = frm;
            frm.Show();

        }

        private void buttongrade07_Click(object sender, EventArgs e)
        {
            Gr_07_Form frm = new Gr_07_Form();
            FormInPanel(panel2, frm);
            //frm.Show();
        }

        private void buttongrade08_Click(object sender, EventArgs e)
        {
            /*UC_Grade08 frm = new UC_Grade08();
            FormInPanel(panel2, frm);*/
        }

        private void buttongrade09_Click(object sender, EventArgs e)
        {
            /*UC_Grade09 frm = new UC_Grade09();
            FormInPanel(panel2, frm);*/
        }

        private void buttongrade10_Click(object sender, EventArgs e)
        {
           /* UC_Grade10 frm = new UC_Grade10();
            FormInPanel(panel2, frm);*/
        }

        private void buttongrade11_Click(object sender, EventArgs e)
        {
            /*UC_Grade11 frm = new UC_Grade11();
            FormInPanel(panel2, frm);*/
        }

        private void buttongrade12_Click(object sender, EventArgs e)
        {
            /*UC_Grade12 frm = new UC_Grade12();
            FormInPanel(panel2, frm);*/
        }

        private void buttongrade13_Click(object sender, EventArgs e)
        {
            /*UC_Grade13 frm = new UC_Grade13();
            FormInPanel(panel2, frm);*/
        }
    } 
}
