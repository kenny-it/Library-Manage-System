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
            SuspendLayout();
            // 
            // DisplayBtn
            // 
            DisplayBtn.Location = new Point(76, 72);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(144, 47);
            DisplayBtn.TabIndex = 0;
            DisplayBtn.Text = "2.1 Display borrowers";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(76, 237);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(144, 47);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "2.2 Search borrower";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(435, 72);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(144, 47);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "2.3 Add borrower";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(435, 237);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(144, 47);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "2.4 Remove borrower";
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.Location = new Point(608, 379);
            Back.Name = "Back";
            Back.Size = new Size(144, 47);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // ManageBorrowers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(SearchBtn);
            Controls.Add(DisplayBtn);
            Name = "ManageBorrowers";
            Text = "ManageBorrowers";
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayBtn;
        private Button SearchBtn;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button Back;
    }
}