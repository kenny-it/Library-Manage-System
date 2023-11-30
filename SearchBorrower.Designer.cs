namespace Library_Manage_System
{
    partial class SearchBorrower
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
            borrowerIDLabel = new Label();
            BorrowerIDText = new NumericUpDown();
            SearchBtn = new Button();
            BorrowerDetailDataGrid = new DataGridView();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BorrowerDetailDataGrid).BeginInit();
            SuspendLayout();
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Location = new Point(59, 57);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new Size(92, 20);
            borrowerIDLabel.TabIndex = 0;
            borrowerIDLabel.Text = "BorrowerID: ";
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(64, 113);
            BorrowerIDText.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            BorrowerIDText.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(150, 27);
            BorrowerIDText.TabIndex = 1;
            BorrowerIDText.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(75, 218);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(139, 57);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BorrowerDetailDataGrid
            // 
            BorrowerDetailDataGrid.AllowUserToAddRows = false;
            BorrowerDetailDataGrid.AllowUserToDeleteRows = false;
            BorrowerDetailDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BorrowerDetailDataGrid.BackgroundColor = Color.White;
            BorrowerDetailDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowerDetailDataGrid.Location = new Point(272, 58);
            BorrowerDetailDataGrid.Name = "BorrowerDetailDataGrid";
            BorrowerDetailDataGrid.ReadOnly = true;
            BorrowerDetailDataGrid.RowHeadersWidth = 51;
            BorrowerDetailDataGrid.RowTemplate.Height = 29;
            BorrowerDetailDataGrid.Size = new Size(516, 330);
            BorrowerDetailDataGrid.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(61, 336);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SearchBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(BorrowerDetailDataGrid);
            Controls.Add(SearchBtn);
            Controls.Add(BorrowerIDText);
            Controls.Add(borrowerIDLabel);
            Name = "SearchBorrower";
            Text = "SearchBorrower";
            ((System.ComponentModel.ISupportInitialize)BorrowerIDText).EndInit();
            ((System.ComponentModel.ISupportInitialize)BorrowerDetailDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label borrowerIDLabel;
        private NumericUpDown BorrowerIDText;
        private Button SearchBtn;
        private DataGridView BorrowerDetailDataGrid;
        private Button BackBtn;
    }
}