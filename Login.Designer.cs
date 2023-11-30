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
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(98, 92);
            UserNameLabel.Margin = new Padding(4, 0, 4, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(111, 28);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "UserName:";
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(243, 92);
            UserNameText.Margin = new Padding(4);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(170, 34);
            UserNameText.TabIndex = 1;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(243, 171);
            PasswordText.Margin = new Padding(4);
            PasswordText.MaxLength = 20;
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(170, 34);
            PasswordText.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(108, 171);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(101, 28);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(326, 263);
            LoginBtn.Margin = new Padding(4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(129, 41);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(108, 263);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(129, 41);
            ResetBtn.TabIndex = 5;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 362);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordText);
            Controls.Add(UserNameText);
            Controls.Add(UserNameLabel);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
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
    }
}