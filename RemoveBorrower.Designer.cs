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
            BorrowerIDText = new NumericUpDown();
            RemoveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).BeginInit();
            SuspendLayout();
            // 
            // borrowerLabel
            // 
            borrowerLabel.AutoSize = true;
            borrowerLabel.Location = new Point(38, 48);
            borrowerLabel.Name = "borrowerLabel";
            borrowerLabel.Size = new Size(377, 20);
            borrowerLabel.TabIndex = 0;
            borrowerLabel.Text = "Please enter the ID of the borrower you wish to remove:";
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(38, 94);
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(150, 27);
            BorrowerIDText.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(40, 173);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(164, 29);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Remove Borrower";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // RemoveBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBtn);
            Controls.Add(BorrowerIDText);
            Controls.Add(borrowerLabel);
            Name = "RemoveBorrower";
            Text = "RemoveBorrower";
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label borrowerLabel;
        private NumericUpDown BorrowerIDText;
        private Button RemoveBtn;
    }
}