namespace Library_Manage_System
{
    partial class RemoveUser
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
            label1 = new Label();
            UsernameText = new TextBox();
            DeleteBtn = new Button();
            BackBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 100);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(123, 142);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(158, 27);
            UsernameText.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Maroon;
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.Info;
            DeleteBtn.Location = new Point(310, 133);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(134, 39);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete User";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(381, 333);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(108, 39);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 46);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 0;
            label2.Text = "Remove User";
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 384);
            Controls.Add(panel1);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UsernameText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveUser";
            Text = "RemoveUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernameText;
        private Button DeleteBtn;
        private Button BackBtn;
        private Panel panel1;
        private Label label2;
    }
}