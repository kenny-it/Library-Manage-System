namespace Library_Manage_System
{
    partial class ManageBooks
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
            backBtn = new Button();
            DisplayBtn = new Button();
            RemoveBtn = new Button();
            SearchBtn = new Button();
            Addbtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Maroon;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("MV Boli", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.ForeColor = SystemColors.Info;
            backBtn.Location = new Point(750, 518);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(152, 60);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // DisplayBtn
            // 
            DisplayBtn.BackColor = Color.Maroon;
            DisplayBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayBtn.ForeColor = Color.White;
            DisplayBtn.Location = new Point(117, 128);
            DisplayBtn.Margin = new Padding(3, 4, 3, 4);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(167, 88);
            DisplayBtn.TabIndex = 1;
            DisplayBtn.Text = "1.1 Display Book";
            DisplayBtn.UseVisualStyleBackColor = false;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.Maroon;
            RemoveBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBtn.ForeColor = Color.White;
            RemoveBtn.Location = new Point(456, 426);
            RemoveBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(167, 95);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "1.4 Remove book";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Maroon;
            SearchBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(456, 225);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(167, 97);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "1.2 Search book";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Maroon;
            Addbtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(117, 351);
            Addbtn.Margin = new Padding(3, 4, 3, 4);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(167, 92);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "1.3 Add book";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 59);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Management";
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(Addbtn);
            Controls.Add(SearchBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(DisplayBtn);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageBooks";
            Text = "Manage Books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Button DisplayBtn;
        private Button RemoveBtn;
        private Button SearchBtn;
        private Button Addbtn;
        private Panel panel1;
        private Label label1;
    }
}