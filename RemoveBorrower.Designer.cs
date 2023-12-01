namespace Library_Manage_System
{
    partial class RemoveBorrower
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
            borrowerLabel = new Label();
            RemoveBtn = new Button();
            BorrowerIDText = new TextBox();
            SuspendLayout();
            // 
            // borrowerLabel
            // 
            borrowerLabel.AutoSize = true;
            borrowerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borrowerLabel.Location = new Point(12, 53);
            borrowerLabel.Name = "borrowerLabel";
            borrowerLabel.Size = new Size(495, 28);
            borrowerLabel.TabIndex = 0;
            borrowerLabel.Text = "Please enter the ID of the borrower you wish to remove:";
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.Maroon;
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBtn.ForeColor = SystemColors.Info;
            RemoveBtn.Location = new Point(326, 170);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(181, 46);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Remove Borrower";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(17, 97);
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(165, 27);
            BorrowerIDText.TabIndex = 3;
            BorrowerIDText.TextChanged += BorrowerIDText_TextChanged;
            // 
            // RemoveBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 285);
            Controls.Add(BorrowerIDText);
            Controls.Add(RemoveBtn);
            Controls.Add(borrowerLabel);
            Name = "RemoveBorrower";
            Text = "RemoveBorrower";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label borrowerLabel;
        private Button RemoveBtn;
        private TextBox BorrowerIDText;
    }
}