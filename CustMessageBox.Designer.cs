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
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 28);
            panel1.TabIndex = 0;
            // 
            // ok
            // 
            ok.BackColor = Color.LightSkyBlue;
            ok.FlatAppearance.BorderColor = Color.White;
            ok.FlatAppearance.BorderSize = 0;
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ok.Location = new Point(149, 164);
            ok.Name = "ok";
            ok.Size = new Size(133, 47);
            ok.TabIndex = 1;
            ok.Text = "O K";
            ok.UseVisualStyleBackColor = false;
            ok.Click += ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 89);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 2;
            label1.Text = "Welcome Message";
            label1.Click += label1_Click;
            // 
            // CustMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 264);
            Controls.Add(label1);
            Controls.Add(ok);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
    }
}