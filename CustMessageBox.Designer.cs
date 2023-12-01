namespace Library_Manage_System
{
    partial class CustMessageBox
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
            panel1 = new Panel();
            ok = new Button();
            Welcome = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 314);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 37);
            panel1.TabIndex = 0;
            // 
            // ok
            // 
            ok.BackColor = Color.Maroon;
            ok.FlatAppearance.BorderColor = Color.White;
            ok.FlatAppearance.BorderSize = 0;
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ok.ForeColor = Color.White;
            ok.Location = new Point(223, 211);
            ok.Margin = new Padding(3, 4, 3, 4);
            ok.Name = "ok";
            ok.Size = new Size(152, 63);
            ok.TabIndex = 1;
            ok.Text = "O K";
            ok.UseVisualStyleBackColor = false;
            ok.Click += ok_Click;
            // 
            // Welcome
            // 
            Welcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome.Location = new Point(132, 84);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(99, 28);
            Welcome.TabIndex = 2;
            Welcome.Text = "Welcome";
            Welcome.Click += label1_Click;
            // 
            // CustMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 351);
            Controls.Add(Welcome);
            Controls.Add(ok);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustMessageBox";
            Load += CustMessageBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ok;
        private Label Welcome;
    }
}