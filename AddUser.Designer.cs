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
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernamelabel.Location = new Point(72, 149);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(108, 28);
            usernamelabel.TabIndex = 0;
            usernamelabel.Text = "Username :";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(178, 151);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(125, 27);
            UsernameText.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(77, 202);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(102, 28);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password :";
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(178, 205);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(125, 27);
            PasswordText.TabIndex = 3;
            // 
            // enterBtn
            // 
            enterBtn.BackColor = Color.Maroon;
            enterBtn.FlatStyle = FlatStyle.Popup;
            enterBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            enterBtn.ForeColor = Color.White;
            enterBtn.Location = new Point(209, 285);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(94, 46);
            enterBtn.TabIndex = 4;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = false;
            enterBtn.Click += enterBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.Info;
            BackBtn.Location = new Point(665, 384);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 54);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BackBtn);
            Controls.Add(enterBtn);
            Controls.Add(PasswordText);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameText);
            Controls.Add(usernamelabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            Text = "AddUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label1;
    }
}