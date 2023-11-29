namespace Library_Manage_System
{
    partial class AddBook
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
            IDLabel = new Label();
            AuthorLabel = new Label();
            YearLabel = new Label();
            PublisherLabel = new Label();
            TitleLabel = new Label();
            IDText = new TextBox();
            TitleText = new TextBox();
            AuthorText = new TextBox();
            PublisherText = new TextBox();
            YearText = new NumericUpDown();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)YearText).BeginInit();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(51, 70);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(31, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID: ";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(51, 198);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(54, 20);
            AuthorLabel.TabIndex = 1;
            AuthorLabel.Text = "Author";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(51, 306);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(44, 20);
            YearLabel.TabIndex = 2;
            YearLabel.Text = "Year: ";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(51, 254);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(76, 20);
            PublisherLabel.TabIndex = 3;
            PublisherLabel.Text = "Publisher: ";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(51, 130);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(45, 20);
            TitleLabel.TabIndex = 4;
            TitleLabel.Text = "Title: ";
            // 
            // IDText
            // 
            IDText.Location = new Point(112, 70);
            IDText.MaxLength = 10;
            IDText.Multiline = true;
            IDText.Name = "IDText";
            IDText.Size = new Size(125, 34);
            IDText.TabIndex = 5;
            // 
            // TitleText
            // 
            TitleText.Location = new Point(112, 130);
            TitleText.MaxLength = 100;
            TitleText.Multiline = true;
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(125, 34);
            TitleText.TabIndex = 6;
            // 
            // AuthorText
            // 
            AuthorText.Location = new Point(112, 198);
            AuthorText.MaxLength = 50;
            AuthorText.Multiline = true;
            AuthorText.Name = "AuthorText";
            AuthorText.Size = new Size(125, 34);
            AuthorText.TabIndex = 7;
            // 
            // PublisherText
            // 
            PublisherText.Location = new Point(133, 251);
            PublisherText.MaxLength = 50;
            PublisherText.Multiline = true;
            PublisherText.Name = "PublisherText";
            PublisherText.Size = new Size(125, 34);
            PublisherText.TabIndex = 8;
            // 
            // YearText
            // 
            YearText.Location = new Point(133, 306);
            YearText.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            YearText.Name = "YearText";
            YearText.Size = new Size(150, 27);
            YearText.TabIndex = 9;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(431, 361);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(138, 41);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Add Book";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddBtn);
            Controls.Add(YearText);
            Controls.Add(PublisherText);
            Controls.Add(AuthorText);
            Controls.Add(TitleText);
            Controls.Add(IDText);
            Controls.Add(TitleLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(YearLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(IDLabel);
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)YearText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label AuthorLabel;
        private Label YearLabel;
        private Label PublisherLabel;
        private Label TitleLabel;
        private TextBox IDText;
        private TextBox TitleText;
        private TextBox AuthorText;
        private TextBox PublisherText;
        private NumericUpDown YearText;
        private Button AddBtn;
    }
}