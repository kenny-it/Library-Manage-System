namespace Library_Manage_System
{
    partial class ManiMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            R1 = new Button();
            R2 = new Button();
            R3 = new Button();
            R5 = new Button();
            R6 = new Button();
            R4 = new Button();
            R7 = new Button();
            panel1 = new Panel();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            btnMin = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            SuspendLayout();
            // 
            // R1
            // 
            R1.BackColor = Color.Maroon;
            R1.FlatStyle = FlatStyle.Popup;
            R1.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R1.ForeColor = Color.White;
            R1.Location = new Point(57, 156);
            R1.Margin = new Padding(3, 4, 3, 4);
            R1.Name = "R1";
            R1.Size = new Size(176, 85);
            R1.TabIndex = 0;
            R1.Text = "R1 Manage books";
            R1.UseVisualStyleBackColor = false;
            R1.Click += R1_Click;
            // 
            // R2
            // 
            R2.BackColor = Color.Maroon;
            R2.FlatStyle = FlatStyle.Popup;
            R2.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R2.ForeColor = Color.PapayaWhip;
            R2.Location = new Point(328, 78);
            R2.Margin = new Padding(3, 4, 3, 4);
            R2.Name = "R2";
            R2.Size = new Size(176, 93);
            R2.TabIndex = 1;
            R2.Text = "R2 Manage borrowers";
            R2.UseVisualStyleBackColor = false;
            R2.Click += R2_Click;
            // 
            // R3
            // 
            R3.BackColor = Color.Maroon;
            R3.FlatStyle = FlatStyle.Popup;
            R3.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R3.ForeColor = Color.Silver;
            R3.Location = new Point(57, 313);
            R3.Margin = new Padding(3, 4, 3, 4);
            R3.Name = "R3";
            R3.Size = new Size(176, 89);
            R3.TabIndex = 2;
            R3.Text = "R3 Borrow book(s)";
            R3.UseVisualStyleBackColor = false;
            R3.Click += R3_Click;
            // 
            // R5
            // 
            R5.BackColor = Color.Maroon;
            R5.FlatStyle = FlatStyle.Popup;
            R5.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R5.ForeColor = Color.Gray;
            R5.Location = new Point(57, 492);
            R5.Margin = new Padding(3, 4, 3, 4);
            R5.Name = "R5";
            R5.Size = new Size(176, 83);
            R5.TabIndex = 3;
            R5.Text = "R5 Useful feature";
            R5.UseVisualStyleBackColor = false;
            R5.Click += R5_Click;
            // 
            // R6
            // 
            R6.BackColor = Color.Maroon;
            R6.FlatStyle = FlatStyle.Popup;
            R6.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R6.ForeColor = Color.Goldenrod;
            R6.Location = new Point(328, 422);
            R6.Margin = new Padding(3, 4, 3, 4);
            R6.Name = "R6";
            R6.Size = new Size(176, 92);
            R6.TabIndex = 4;
            R6.Text = "R6 Member List";
            R6.UseVisualStyleBackColor = false;
            R6.Click += R6_Click;
            // 
            // R4
            // 
            R4.BackColor = Color.Maroon;
            R4.FlatStyle = FlatStyle.Popup;
            R4.Font = new Font("Ink Free", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            R4.ForeColor = Color.NavajoWhite;
            R4.Location = new Point(328, 259);
            R4.Margin = new Padding(3, 4, 3, 4);
            R4.Name = "R4";
            R4.Size = new Size(176, 92);
            R4.TabIndex = 5;
            R4.Text = "R4 Return book(s)";
            R4.UseVisualStyleBackColor = false;
            R4.Click += R4_Click;
            // 
            // R7
            // 
            R7.BackColor = Color.Maroon;
            R7.FlatStyle = FlatStyle.Popup;
            R7.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            R7.ForeColor = Color.White;
            R7.Location = new Point(540, 543);
            R7.Margin = new Padding(3, 4, 3, 4);
            R7.Name = "R7";
            R7.Size = new Size(176, 44);
            R7.TabIndex = 6;
            R7.Text = "R7 Exit";
            R7.UseVisualStyleBackColor = false;
            R7.Click += R7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 50);
            panel1.TabIndex = 7;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Image = Properties.Resources.max;
            btnMax.Location = new Point(651, 8);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(32, 32);
            btnMax.SizeMode = PictureBoxSizeMode.Zoom;
            btnMax.TabIndex = 11;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(695, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 10;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Image = Properties.Resources.min;
            btnMin.Location = new Point(607, 8);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(32, 32);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 9;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(259, 8);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 8;
            label1.Text = "Library System";
            // 
            // ManiMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 600);
            Controls.Add(panel1);
            Controls.Add(R7);
            Controls.Add(R4);
            Controls.Add(R6);
            Controls.Add(R5);
            Controls.Add(R3);
            Controls.Add(R2);
            Controls.Add(R1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManiMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            Load += ManiMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button R1;
        private Button R2;
        private Button R3;
        private Button R5;
        private Button R6;
        private Button R4;
        private Button R7;
        private Panel panel1;
        private Label label1;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnClose;
    }
}