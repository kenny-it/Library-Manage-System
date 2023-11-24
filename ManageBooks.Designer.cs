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
            backBtn.Location = new Point(611, 363);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(133, 45);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // DisplayBtn
            // 
            DisplayBtn.Location = new Point(79, 58);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(146, 48);
            DisplayBtn.TabIndex = 1;
            DisplayBtn.Text = "1.1 Display Book";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(415, 201);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(146, 48);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "1.4 Remove book";
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(79, 201);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(146, 48);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "1.2 Search book";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(414, 58);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(146, 48);
            Addbtn.TabIndex = 5;
            Addbtn.Text = "1.3 Add book";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Addbtn);
            Controls.Add(SearchBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(DisplayBtn);
            Controls.Add(backBtn);
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