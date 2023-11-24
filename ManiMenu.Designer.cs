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
            SuspendLayout();
            // 
            // R1
            // 
            R1.Location = new Point(31, 50);
            R1.Name = "R1";
            R1.Size = new Size(154, 35);
            R1.TabIndex = 0;
            R1.Text = "R1 Manage books";
            R1.UseVisualStyleBackColor = true;
            R1.Click += R1_Click;
            // 
            // R2
            // 
            R2.Location = new Point(31, 141);
            R2.Name = "R2";
            R2.Size = new Size(154, 33);
            R2.TabIndex = 1;
            R2.Text = "R2 Manage borrowers";
            R2.UseVisualStyleBackColor = true;
            R2.Click += R2_Click;
            // 
            // R3
            // 
            R3.Location = new Point(31, 244);
            R3.Name = "R3";
            R3.Size = new Size(154, 33);
            R3.TabIndex = 2;
            R3.Text = "R3 Borrow book(s)";
            R3.UseVisualStyleBackColor = true;
            // 
            // R5
            // 
            R5.Location = new Point(359, 141);
            R5.Name = "R5";
            R5.Size = new Size(154, 33);
            R5.TabIndex = 3;
            R5.Text = "R5 Useful Features";
            R5.UseVisualStyleBackColor = true;
            // 
            // R6
            // 
            R6.Location = new Point(359, 244);
            R6.Name = "R6";
            R6.Size = new Size(154, 33);
            R6.TabIndex = 4;
            R6.Text = "R6 Member List";
            R6.UseVisualStyleBackColor = true;
            R6.Click += R6_Click;
            // 
            // R4
            // 
            R4.Location = new Point(359, 52);
            R4.Name = "R4";
            R4.Size = new Size(154, 33);
            R4.TabIndex = 5;
            R4.Text = "R4 Return book(s)";
            R4.UseVisualStyleBackColor = true;
            // 
            // R7
            // 
            R7.Location = new Point(575, 374);
            R7.Name = "R7";
            R7.Size = new Size(154, 33);
            R7.TabIndex = 6;
            R7.Text = "R7 Exit";
            R7.UseVisualStyleBackColor = true;
            R7.Click += R7_Click;
            // 
            // ManiMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(R7);
            Controls.Add(R4);
            Controls.Add(R6);
            Controls.Add(R5);
            Controls.Add(R3);
            Controls.Add(R2);
            Controls.Add(R1);
            Name = "ManiMenu";
            Text = "Library Management System";
            Load += ManiMenu_Load;
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
    }
}