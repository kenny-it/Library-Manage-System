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
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(698, 484);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(152, 60);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // DisplayBtn
            // 
            DisplayBtn.Location = new Point(90, 77);
            DisplayBtn.Margin = new Padding(3, 4, 3, 4);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(167, 64);
            DisplayBtn.TabIndex = 1;
            DisplayBtn.Text = "1.1 Display Book";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(474, 268);
            RemoveBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(167, 64);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "1.4 Remove book";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(90, 268);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(167, 64);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "1.2 Search book";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(473, 77);
            Addbtn.Margin = new Padding(3, 4, 3, 4);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(167, 64);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "1.3 Add book";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Addbtn);
            Controls.Add(SearchBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(DisplayBtn);
            Controls.Add(backBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageBooks";
            Text = "Manage Books";
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private Button DisplayBtn;
        private Button RemoveBtn;
        private Button SearchBtn;
        private Button Addbtn;
    }
}