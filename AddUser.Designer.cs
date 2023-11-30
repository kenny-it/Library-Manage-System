namespace Library_Manage_System
{
    partial class AddUser
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
            usernamelabel = new Label();
            UsernameText = new TextBox();
            PasswordLabel = new Label();
            PasswordText = new TextBox();
            enterBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(86, 94);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(75, 20);
            usernamelabel.TabIndex = 0;
            usernamelabel.Text = "Username";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(92, 131);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(125, 27);
            UsernameText.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(92, 217);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(92, 250);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(125, 27);
            PasswordText.TabIndex = 3;
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(318, 327);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(94, 29);
            enterBtn.TabIndex = 4;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(474, 327);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(enterBtn);
            Controls.Add(PasswordText);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameText);
            Controls.Add(usernamelabel);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernamelabel;
        private TextBox UsernameText;
        private Label PasswordLabel;
        private TextBox PasswordText;
        private Button enterBtn;
        private Button BackBtn;
    }
}