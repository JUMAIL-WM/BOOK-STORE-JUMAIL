namespace BOOK_STORE.Books_Forms
{
    partial class Gr_06_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTutorialNotes = new System.Windows.Forms.Button();
            this.buttonExamePaper = new System.Windows.Forms.Button();
            this.buttonSchoolBooks = new System.Windows.Forms.Button();
            this.buttonModelPaper = new System.Windows.Forms.Button();
            this.buttonPassPaper = new System.Windows.Forms.Button();
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonTutorialNotes, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonExamePaper, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSchoolBooks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonModelPaper, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPassPaper, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 59);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonTutorialNotes
            // 
            this.buttonTutorialNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTutorialNotes.Location = new System.Drawing.Point(771, 3);
            this.buttonTutorialNotes.Name = "buttonTutorialNotes";
            this.buttonTutorialNotes.Size = new System.Drawing.Size(188, 53);
            this.buttonTutorialNotes.TabIndex = 2;
            this.buttonTutorialNotes.Text = "TUTORIAL NOTES";
            this.buttonTutorialNotes.UseVisualStyleBackColor = true;
            // 
            // buttonExamePaper
            // 
            this.buttonExamePaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExamePaper.Location = new System.Drawing.Point(579, 3);
            this.buttonExamePaper.Name = "buttonExamePaper";
            this.buttonExamePaper.Size = new System.Drawing.Size(186, 53);
            this.buttonExamePaper.TabIndex = 2;
            this.buttonExamePaper.Text = "EXAME PAPER";
            this.buttonExamePaper.UseVisualStyleBackColor = true;
            // 
            // buttonSchoolBooks
            // 
            this.buttonSchoolBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSchoolBooks.Location = new System.Drawing.Point(387, 3);
            this.buttonSchoolBooks.Name = "buttonSchoolBooks";
            this.buttonSchoolBooks.Size = new System.Drawing.Size(186, 53);
            this.buttonSchoolBooks.TabIndex = 2;
            this.buttonSchoolBooks.Text = "SCHOOL BOOKS";
            this.buttonSchoolBooks.UseVisualStyleBackColor = true;
            // 
            // buttonModelPaper
            // 
            this.buttonModelPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModelPaper.Location = new System.Drawing.Point(195, 3);
            this.buttonModelPaper.Name = "buttonModelPaper";
            this.buttonModelPaper.Size = new System.Drawing.Size(186, 53);
            this.buttonModelPaper.TabIndex = 2;
            this.buttonModelPaper.Text = "MODEL PAPER";
            this.buttonModelPaper.UseVisualStyleBackColor = true;
            // 
            // buttonPassPaper
            // 
            this.buttonPassPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPassPaper.Location = new System.Drawing.Point(3, 3);
            this.buttonPassPaper.Name = "buttonPassPaper";
            this.buttonPassPaper.Size = new System.Drawing.Size(186, 53);
            this.buttonPassPaper.TabIndex = 0;
            this.buttonPassPaper.Text = "PASS PAPER";
            this.buttonPassPaper.UseVisualStyleBackColor = true;
            this.buttonPassPaper.Click += new System.EventHandler(this.ButtonPassPaper_Click);
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 59);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(962, 463);
            this.radPdfViewer1.TabIndex = 2;
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // Gr_06_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 522);
            this.Controls.Add(this.radPdfViewer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gr_06_Form";
            this.Text = "Gr_06_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPassPaper;
        private System.Windows.Forms.Button buttonTutorialNotes;
        private System.Windows.Forms.Button buttonExamePaper;
        private System.Windows.Forms.Button buttonSchoolBooks;
        private System.Windows.Forms.Button buttonModelPaper;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
    }
}