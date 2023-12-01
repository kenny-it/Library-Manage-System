namespace Library_Manage_System
{
    partial class ManageBorrowers
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
            DisplayBtn = new Button();
            SearchBtn = new Button();
            AddBtn = new Button();
            RemoveBtn = new Button();
            Back = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayBtn
            // 
            DisplayBtn.BackColor = Color.Maroon;
            DisplayBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayBtn.ForeColor = Color.White;
            DisplayBtn.Location = new Point(123, 110);
            DisplayBtn.Margin = new Padding(3, 4, 3, 4);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(165, 104);
            DisplayBtn.TabIndex = 0;
            DisplayBtn.Text = "2.1 Display borrowers";
            DisplayBtn.UseVisualStyleBackColor = false;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Maroon;
            SearchBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(456, 216);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(165, 104);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "2.2 Search borrower";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Maroon;
            AddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ControlLightLight;
            AddBtn.Location = new Point(123, 357);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(165, 104);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "2.3 Add borrower";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.Maroon;
            RemoveBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBtn.ForeColor = Color.White;
            RemoveBtn.Location = new Point(456, 458);
            RemoveBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(165, 104);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "2.4 Remove borrower";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Maroon;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(737, 524);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(165, 63);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 59);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 37);
            label1.TabIndex = 1;
            label1.Text = "Borrower Management";
            // 
            // ManageBorrowers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(Back);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(SearchBtn);
            Controls.Add(DisplayBtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageBorrowers";
            Text = "ManageBorrowers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayBtn;
        private Button SearchBtn;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button Back;
        private Panel panel1;
        private Label label1;
    }
}