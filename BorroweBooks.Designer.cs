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
            BorrowerIDText = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).BeginInit();
            SuspendLayout();
            // 
            // BookIDText
            // 
            BookIDText.Location = new Point(94, 168);
            BookIDText.Name = "BookIDText";
            BookIDText.Size = new Size(146, 27);
            BookIDText.TabIndex = 1;
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
            // FinishBtn
            // 
            FinishBtn.Location = new Point(632, 377);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(94, 29);
            FinishBtn.TabIndex = 3;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
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
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(99, 77);
            BorrowerIDText.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            BorrowerIDText.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(150, 27);
            BorrowerIDText.TabIndex = 6;
            BorrowerIDText.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(451, 20);
            label1.TabIndex = 7;
            label1.Text = "Please enter your borrower ID and the book ID you wish to borrow.";
            // 
            // BorroweBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BorrowerIDText);
            Controls.Add(BookIDLable);
            Controls.Add(BorrowerIDLable);
            Controls.Add(FinishBtn);
            Controls.Add(BorrowBtn);
            Controls.Add(BookIDText);
            Name = "BorroweBooks";
            Text = "BorroweBooks";
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox BookIDText;
        private Button BorrowBtn;
        private Button FinishBtn;
        private Label BorrowerIDLable;
        private Label BookIDLable;
        private NumericUpDown BorrowerIDText;
        private Label label1;
    }
}