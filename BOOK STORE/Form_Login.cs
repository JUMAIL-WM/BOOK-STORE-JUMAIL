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

namespace BOOK_STORE
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            textBoxUname.Select();
            buttonLogin.Click += ButtonLogin_Click;
            buttonOff.Click += ButtonOff_Click;
            pictureBoxHide.MouseHover += PictureBoxHide_MouseHover;
            pictureBoxHide.MouseLeave += PictureBoxHide_MouseLeave;
            
        }

        private void PictureBoxHide_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar= true;
        }

        private void PictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar= false;
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
           //from  UI

           string Username = textBoxUname.Text.Trim();
           string Password = textBoxPassword.Text.Trim();

            //from DB

            var _Ls = new Login_Service();
            var un = _Ls.ListAllData().SingleOrDefault().UserName.Trim();
            var pw = _Ls.ListAllData().SingleOrDefault().Password.Trim();

            if (un == Username && pw == Password)
            {
                MessageBox.Show("Login Success!!!","Login",MessageBoxButtons.OK, MessageBoxIcon.Information);

                var frm = new Form_Dashboard();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Error!!!\nPlease check your Username and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUname.Clear();
                textBoxPassword.Clear();
                textBoxUname.Select();
                return;
            }
        }
    }
}
