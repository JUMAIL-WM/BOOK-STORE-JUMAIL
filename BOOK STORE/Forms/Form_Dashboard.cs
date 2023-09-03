using BOOK_STORE.UserControls;
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
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelleft.Width;
            isCollapsed = false;

            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);

            buttonClose.Click += ButtonClose_Click;    
           
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Wnat to closs???", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  Application.Exit();
                }
            else
                {
                    
                }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10; 
                if (panelleft.Width >= PanelWidth)
                {
                   timer1.Stop();
                   isCollapsed = false;
                   this.Refresh();
                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 58)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
             
            labelTime.Text = DateTime.Now.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome); /*Home*/
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSaleBooks);
            UC_Sales us = new UC_Sales();
            AddControlsToPanel(us);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPurchase);
            UC_PurchaseDetails up = new UC_PurchaseDetails();
            AddControlsToPanel(up);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpense);
            UC_ManageExpense us = new UC_ManageExpense();
            AddControlsToPanel(us);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonUsers); /*user*/
            UC_ManageUser user = new UC_ManageUser();
            AddControlsToPanel(user);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(buttonViewSales); /*view sales*/
            UC_ViewSales sales = new UC_ViewSales();
            AddControlsToPanel(sales);
        }

    }
}
