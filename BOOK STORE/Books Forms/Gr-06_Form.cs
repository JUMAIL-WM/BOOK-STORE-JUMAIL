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

namespace BOOK_STORE.Books_Forms
{
    public partial class Gr_06_Form : Form
    {
        public Gr_06_Form()
        {
            InitializeComponent();
            buttonPassPaper.Click += ButtonPassPaper_Click;
            buttonModelPaper.Click += ButtonModelPaper_Click;
            buttonSchoolBooks.Click += ButtonSchoolBooks_Click;
            buttonExamePaper.Click += ButtonExamePaper_Click;
            buttonTutorialNotes.Click += ButtonTutorialNotes_Click;
        }

        private void ButtonTutorialNotes_Click(object sender, EventArgs e)
        {
            radPdfViewer1.LoadDocument(@"C:\Users\Futuremind\Desktop\C# to MySQL coding\BOOK STORE\BOOK STORE\bin\Gr-06 BOOKS\History G 6.pdf");
           
        }

        private void ButtonExamePaper_Click(object sender, EventArgs e)
        {
            radPdfViewer1.LoadDocument(@"C:\Users\Futuremind\Desktop\C# to MySQL coding\BOOK STORE\BOOK STORE\bin\Gr-06 BOOKS\Grade 6_Tamil_1st Term 2018.pdf");
            
        }

        private void ButtonSchoolBooks_Click(object sender, EventArgs e)
        {
            radPdfViewer1.LoadDocument(@"C:\Users\Futuremind\Desktop\C# to MySQL coding\BOOK STORE\BOOK STORE\bin\Gr-06 BOOKS\book (1).pdf");
           
        }

        private void ButtonModelPaper_Click(object sender, EventArgs e)
        {
            radPdfViewer1.LoadDocument(@"C:\Users\Futuremind\Desktop\C# to MySQL coding\BOOK STORE\BOOK STORE\bin\Gr-06 BOOKS\Grade 6_ICT.pdf");
           
        }

        private void ButtonPassPaper_Click(object sender, EventArgs e)
        {
            radPdfViewer1.LoadDocument(@"C:\Users\Futuremind\Desktop\C# to MySQL coding\BOOK STORE\BOOK STORE\bin\Gr-06 BOOKS\combinepdf.pdf");
            
        }

    }
}
