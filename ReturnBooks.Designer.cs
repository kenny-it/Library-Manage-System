namespace Library_Manage_System
{
    partial class ReturnBooks
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
            label1 = new Label();
            label2 = new Label();
            BookIDText = new TextBox();
            label3 = new Label();
            BorrowBtn = new Button();
            FinishBtn = new Button();
            BorrowerIDText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(286, 30);
            label1.TabIndex = 8;
            label1.Text = "Welcome to ReturnBook\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(212, 40);
            label2.TabIndex = 10;
            label2.Text = "Please enter your borrow ID\r\n\r\n";
            // 
            // BookIDText
            // 
            BookIDText.Location = new Point(260, 135);
            BookIDText.Name = "BookIDText";
            BookIDText.Size = new Size(146, 27);
            BookIDText.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 135);
            label3.Name = "label3";
            label3.Size = new Size(196, 40);
            label3.TabIndex = 12;
            label3.Text = "Please enter your book ID\r\n\r\n";
            // 
            // BorrowBtn
            // 
            BorrowBtn.Location = new Point(260, 211);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(94, 29);
            BorrowBtn.TabIndex = 13;
            BorrowBtn.Text = "Return";
            BorrowBtn.UseVisualStyleBackColor = true;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // FinishBtn
            // 
            FinishBtn.Location = new Point(360, 211);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(94, 29);
            FinishBtn.TabIndex = 14;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(262, 70);
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(144, 27);
            BorrowerIDText.TabIndex = 15;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 264);
            Controls.Add(BorrowerIDText);
            Controls.Add(FinishBtn);
            Controls.Add(BorrowBtn);
            Controls.Add(label3);
            Controls.Add(BookIDText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnBooks";
            Text = "Return";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BookIDText;
        private Label label3;
        private Button BorrowBtn;
        private Button FinishBtn;
        private TextBox BorrowerIDText;
    }
}