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
            panel1 = new Panel();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            label1 = new Label();
            btnMin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            SuspendLayout();
            // 
            // DisplayBtn
            // 
            DisplayBtn.BackColor = Color.Maroon;
            DisplayBtn.Font = new Font("Ink Free", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBtn.ForeColor = Color.Snow;
            DisplayBtn.Location = new Point(63, 96);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(175, 85);
            DisplayBtn.TabIndex = 0;
            DisplayBtn.Text = "Display User";
            DisplayBtn.UseVisualStyleBackColor = false;
            DisplayBtn.Click += DisplayBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.Maroon;
            AddUserBtn.Font = new Font("Ink Free", 16F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserBtn.ForeColor = Color.Snow;
            AddUserBtn.Location = new Point(63, 255);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(175, 83);
            AddUserBtn.TabIndex = 1;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // RemoveUserBtn
            // 
            RemoveUserBtn.BackColor = Color.Maroon;
            RemoveUserBtn.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveUserBtn.ForeColor = Color.Snow;
            RemoveUserBtn.Location = new Point(376, 145);
            RemoveUserBtn.Name = "RemoveUserBtn";
            RemoveUserBtn.Size = new Size(185, 80);
            RemoveUserBtn.TabIndex = 2;
            RemoveUserBtn.Text = "Remove User";
            RemoveUserBtn.UseVisualStyleBackColor = false;
            RemoveUserBtn.Click += RemoveUserBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.BackColor = Color.Maroon;
            HistoryBtn.Font = new Font("Ink Free", 16F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryBtn.ForeColor = Color.Snow;
            HistoryBtn.Location = new Point(376, 307);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(185, 78);
            HistoryBtn.TabIndex = 3;
            HistoryBtn.Text = "Display History";
            HistoryBtn.UseVisualStyleBackColor = false;
            HistoryBtn.Click += HistoryBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.Info;
            BackBtn.Location = new Point(685, 392);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(103, 46);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 7;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Image = Properties.Resources.max;
            btnMax.Location = new Point(713, 14);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(32, 32);
            btnMax.SizeMode = PictureBoxSizeMode.Zoom;
            btnMax.TabIndex = 14;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(757, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 13;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Image = Properties.Resources.min;
            btnMin.Location = new Point(669, 14);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(32, 32);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 12;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BackBtn);
            Controls.Add(HistoryBtn);
            Controls.Add(RemoveUserBtn);
            Controls.Add(AddUserBtn);
            Controls.Add(DisplayBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUser";
            Text = "ManageUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayBtn;
        private Button AddUserBtn;
        private Button RemoveUserBtn;
        private Button HistoryBtn;
        private Button BackBtn;
        private Panel panel1;
        private Label label1;
        private PictureBox btnMax;
        private PictureBox btnClose;
        private PictureBox btnMin;
    }
}