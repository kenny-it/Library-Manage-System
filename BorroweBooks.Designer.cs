namespace Library_Manage_System
{
    partial class BorroweBooks
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
            BookIDText = new TextBox();
            BorrowBtn = new Button();
            FinishBtn = new Button();
            BorrowerIDLable = new Label();
            BookIDLable = new Label();
            label1 = new Label();
            BorrowerIDText = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BookIDText
            // 
            BookIDText.Location = new Point(238, 174);
            BookIDText.Name = "BookIDText";
            BookIDText.Size = new Size(213, 27);
            BookIDText.TabIndex = 1;
            // 
            // BorrowBtn
            // 
            BorrowBtn.BackColor = Color.Maroon;
            BorrowBtn.FlatStyle = FlatStyle.Popup;
            BorrowBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowBtn.ForeColor = Color.White;
            BorrowBtn.Location = new Point(238, 244);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(116, 53);
            BorrowBtn.TabIndex = 2;
            BorrowBtn.Text = "Borrow";
            BorrowBtn.UseVisualStyleBackColor = false;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = Color.Maroon;
            FinishBtn.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FinishBtn.ForeColor = SystemColors.Info;
            FinishBtn.Location = new Point(640, 357);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(111, 54);
            FinishBtn.TabIndex = 3;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // BorrowerIDLable
            // 
            BorrowerIDLable.AutoSize = true;
            BorrowerIDLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowerIDLable.Location = new Point(94, 112);
            BorrowerIDLable.Name = "BorrowerIDLable";
            BorrowerIDLable.Size = new Size(116, 28);
            BorrowerIDLable.TabIndex = 4;
            BorrowerIDLable.Text = "Borrower ID";
            // 
            // BookIDLable
            // 
            BookIDLable.AutoSize = true;
            BookIDLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookIDLable.Location = new Point(128, 170);
            BookIDLable.Name = "BookIDLable";
            BookIDLable.Size = new Size(81, 28);
            BookIDLable.TabIndex = 5;
            BookIDLable.Text = "Book ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 60);
            label1.Name = "label1";
            label1.Size = new Size(595, 28);
            label1.TabIndex = 7;
            label1.Text = "Please enter your borrower ID and the book ID you wish to borrow.";
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(238, 113);
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(213, 27);
            BorrowerIDText.TabIndex = 8;
            BorrowerIDText.TextChanged += BorrowerIDText_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(205, 40);
            label2.TabIndex = 1;
            label2.Text = "Borrow Book";
            // 
            // BorroweBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BorrowerIDText);
            Controls.Add(label1);
            Controls.Add(BookIDLable);
            Controls.Add(BorrowerIDLable);
            Controls.Add(FinishBtn);
            Controls.Add(BorrowBtn);
            Controls.Add(BookIDText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorroweBooks";
            Text = "BorroweBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox BookIDText;
        private Button BorrowBtn;
        private Button FinishBtn;
        private Label BorrowerIDLable;
        private Label BookIDLable;
        private Label label1;
        private TextBox BorrowerIDText;
        private Panel panel1;
        private Label label2;
    }
}