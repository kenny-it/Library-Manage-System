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
            BorrowerIDBtn = new TextBox();
            BookIDBtn = new TextBox();
            BorrowBtn = new Button();
            button2 = new Button();
            BorrowerIDLable = new Label();
            BookIDLable = new Label();
            SuspendLayout();
            // 
            // BorrowerIDBtn
            // 
            BorrowerIDBtn.Location = new Point(94, 77);
            BorrowerIDBtn.Name = "BorrowerIDBtn";
            BorrowerIDBtn.Size = new Size(146, 27);
            BorrowerIDBtn.TabIndex = 0;
            // 
            // BookIDBtn
            // 
            BookIDBtn.Location = new Point(94, 168);
            BookIDBtn.Name = "BookIDBtn";
            BookIDBtn.Size = new Size(146, 27);
            BookIDBtn.TabIndex = 1;
            // 
            // BorrowBtn
            // 
            BorrowBtn.Location = new Point(632, 313);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(94, 29);
            BorrowBtn.TabIndex = 2;
            BorrowBtn.Text = "Borrow";
            BorrowBtn.UseVisualStyleBackColor = true;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 377);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // BorrowerIDLable
            // 
            BorrowerIDLable.AutoSize = true;
            BorrowerIDLable.Location = new Point(94, 43);
            BorrowerIDLable.Name = "BorrowerIDLable";
            BorrowerIDLable.Size = new Size(89, 20);
            BorrowerIDLable.TabIndex = 4;
            BorrowerIDLable.Text = "Borrower ID";
            // 
            // BookIDLable
            // 
            BookIDLable.AutoSize = true;
            BookIDLable.Location = new Point(94, 145);
            BookIDLable.Name = "BookIDLable";
            BookIDLable.Size = new Size(62, 20);
            BookIDLable.TabIndex = 5;
            BookIDLable.Text = "Book ID";
            // 
            // BorroweBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookIDLable);
            Controls.Add(BorrowerIDLable);
            Controls.Add(button2);
            Controls.Add(BorrowBtn);
            Controls.Add(BookIDBtn);
            Controls.Add(BorrowerIDBtn);
            Name = "BorroweBooks";
            Text = "BorroweBooks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BorrowerIDBtn;
        private TextBox BookIDBtn;
        private Button BorrowBtn;
        private Button button2;
        private Label BorrowerIDLable;
        private Label BookIDLable;
    }
}