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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            keywordLable = new Label();
            keywordText = new TextBox();
            SearchBtn = new Button();
            SearchBookDataGrid = new DataGridView();
            BackBtn = new Button();
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
            keywordText.Location = new Point(35, 77);
            keywordText.MaxLength = 50;
            keywordText.Multiline = true;
            keywordText.Name = "keywordText";
            keywordText.Size = new Size(137, 34);
            keywordText.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(35, 166);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(104, 42);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchBookDataGrid
            // 
            SearchBookDataGrid.AllowUserToAddRows = false;
            SearchBookDataGrid.AllowUserToDeleteRows = false;
            SearchBookDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchBookDataGrid.BackgroundColor = Color.White;
            SearchBookDataGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SearchBookDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            SearchBookDataGrid.Location = new Point(284, 44);
            SearchBookDataGrid.Name = "SearchBookDataGrid";
            SearchBookDataGrid.ReadOnly = true;
            SearchBookDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SearchBookDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            SearchBookDataGrid.RowTemplate.Height = 50;
            SearchBookDataGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            SearchBookDataGrid.Size = new Size(504, 308);
            SearchBookDataGrid.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(35, 255);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(106, 39);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
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
        private Button BackBtn;
    }
}