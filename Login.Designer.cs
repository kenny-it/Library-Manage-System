namespace Library_Manage_System
{
    partial class Login
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
            UserNameLabel = new Label();
            UserNameText = new TextBox();
            PasswordText = new TextBox();
            PasswordLabel = new Label();
            LoginBtn = new Button();
            ResetBtn = new Button();
            panel1 = new Panel();
            btnMin = new PictureBox();
            btnClose = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(114, 92);
            UserNameLabel.Margin = new Padding(4, 0, 4, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(122, 29);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "UserName:";
            // 
            // UserNameText
            // 
            UserNameText.BorderStyle = BorderStyle.None;
            UserNameText.Location = new Point(243, 94);
            UserNameText.Margin = new Padding(4);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(170, 27);
            UserNameText.TabIndex = 1;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.White;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Location = new Point(243, 174);
            PasswordText.Margin = new Padding(4);
            PasswordText.MaxLength = 20;
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(170, 27);
            PasswordText.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(122, 172);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(111, 29);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Maroon;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(326, 263);
            LoginBtn.Margin = new Padding(4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(129, 41);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Maroon;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(108, 263);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(129, 41);
            ResetBtn.TabIndex = 5;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 50);
            panel1.TabIndex = 6;
            // 
            // btnMin
            // 
            btnMin.Image = Properties.Resources.min;
            btnMin.Location = new Point(486, 14);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(32, 32);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 3;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(533, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "Library System";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(234, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(234, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(564, 409);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordText);
            Controls.Add(UserNameText);
            Controls.Add(UserNameLabel);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(564, 409);
            MinimumSize = new Size(564, 409);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private TextBox UserNameText;
        private TextBox PasswordText;
        private Label PasswordLabel;
        private Button LoginBtn;
        private Button ResetBtn;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btnMin;
        private PictureBox btnClose;
    }
}