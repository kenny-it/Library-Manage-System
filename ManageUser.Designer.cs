namespace Library_Manage_System
{
    partial class ManageUser
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
            AddUserBtn = new Button();
            RemoveUserBtn = new Button();
            HistoryBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // DisplayBtn
            // 
            DisplayBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DisplayBtn.Location = new Point(63, 96);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(173, 62);
            DisplayBtn.TabIndex = 0;
            DisplayBtn.Text = "Display User";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AddUserBtn.Location = new Point(53, 251);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(173, 62);
            AddUserBtn.TabIndex = 1;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // RemoveUserBtn
            // 
            RemoveUserBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RemoveUserBtn.Location = new Point(376, 96);
            RemoveUserBtn.Name = "RemoveUserBtn";
            RemoveUserBtn.Size = new Size(173, 62);
            RemoveUserBtn.TabIndex = 2;
            RemoveUserBtn.Text = "Remove User";
            RemoveUserBtn.UseVisualStyleBackColor = true;
            RemoveUserBtn.Click += RemoveUserBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HistoryBtn.Location = new Point(376, 251);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(173, 62);
            HistoryBtn.TabIndex = 3;
            HistoryBtn.Text = "Display History";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BackBtn.Location = new Point(601, 373);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(103, 46);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(HistoryBtn);
            Controls.Add(RemoveUserBtn);
            Controls.Add(AddUserBtn);
            Controls.Add(DisplayBtn);
            Name = "ManageUser";
            Text = "ManageUser";
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayBtn;
        private Button AddUserBtn;
        private Button RemoveUserBtn;
        private Button HistoryBtn;
        private Button BackBtn;
    }
}