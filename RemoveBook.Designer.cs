namespace Library_Manage_System
{
    partial class RemoveBook
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
            BookIDLabel = new Label();
            BookIDText = new TextBox();
            RemoveBtn = new Button();
            SuspendLayout();
            // 
            // BookIDLabel
            // 
            BookIDLabel.AutoSize = true;
            BookIDLabel.Location = new Point(82, 66);
            BookIDLabel.Name = "BookIDLabel";
            BookIDLabel.Size = new Size(116, 20);
            BookIDLabel.TabIndex = 0;
            BookIDLabel.Text = "RemoveBook ID";
            // 
            // BookIDText
            // 
            BookIDText.Location = new Point(85, 105);
            BookIDText.MaxLength = 20;
            BookIDText.Multiline = true;
            BookIDText.Name = "BookIDText";
            BookIDText.Size = new Size(125, 34);
            BookIDText.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(117, 238);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(94, 29);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Remove book";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // RemoveBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBtn);
            Controls.Add(BookIDText);
            Controls.Add(BookIDLabel);
            Name = "RemoveBook";
            Text = "RemoveBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookIDLabel;
        private TextBox BookIDText;
        private Button RemoveBtn;
    }
}