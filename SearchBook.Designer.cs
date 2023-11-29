namespace Library_Manage_System
{
    partial class SearchBook
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
            keywordLable = new Label();
            keywordText = new TextBox();
            SearchBtn = new Button();
            SearchBookDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SearchBookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // keywordLable
            // 
            keywordLable.AutoSize = true;
            keywordLable.Location = new Point(35, 36);
            keywordLable.Name = "keywordLable";
            keywordLable.Size = new Size(71, 20);
            keywordLable.TabIndex = 0;
            keywordLable.Text = "keywords";
            // 
            // keywordText
            // 
            keywordText.Location = new Point(40, 87);
            keywordText.MaxLength = 50;
            keywordText.Multiline = true;
            keywordText.Name = "keywordText";
            keywordText.Size = new Size(137, 34);
            keywordText.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(35, 178);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchBookDataGrid
            // 
            SearchBookDataGrid.AllowUserToAddRows = false;
            SearchBookDataGrid.AllowUserToDeleteRows = false;
            SearchBookDataGrid.BackgroundColor = Color.White;
            SearchBookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchBookDataGrid.Location = new Point(284, 44);
            SearchBookDataGrid.Name = "SearchBookDataGrid";
            SearchBookDataGrid.ReadOnly = true;
            SearchBookDataGrid.RowHeadersWidth = 51;
            SearchBookDataGrid.RowTemplate.Height = 29;
            SearchBookDataGrid.Size = new Size(504, 308);
            SearchBookDataGrid.TabIndex = 3;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBookDataGrid);
            Controls.Add(SearchBtn);
            Controls.Add(keywordText);
            Controls.Add(keywordLable);
            Name = "SearchBook";
            Text = "SearchBook";
            ((System.ComponentModel.ISupportInitialize)SearchBookDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label keywordLable;
        private TextBox keywordText;
        private Button SearchBtn;
        private DataGridView SearchBookDataGrid;
    }
}