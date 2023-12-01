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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SearchBookDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // keywordLable
            // 
            keywordLable.AutoSize = true;
            keywordLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            keywordLable.Location = new Point(35, 137);
            keywordLable.Name = "keywordLable";
            keywordLable.Size = new Size(104, 28);
            keywordLable.TabIndex = 0;
            keywordLable.Text = "keywords :";
            // 
            // keywordText
            // 
            keywordText.Location = new Point(35, 183);
            keywordText.MaxLength = 50;
            keywordText.Multiline = true;
            keywordText.Name = "keywordText";
            keywordText.Size = new Size(137, 34);
            keywordText.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Maroon;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = SystemColors.ControlLightLight;
            SearchBtn.Location = new Point(35, 264);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(104, 42);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchBookDataGrid
            // 
            SearchBookDataGrid.AllowUserToAddRows = false;
            SearchBookDataGrid.AllowUserToDeleteRows = false;
            SearchBookDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchBookDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchBookDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            SearchBookDataGrid.Location = new Point(211, 44);
            SearchBookDataGrid.Name = "SearchBookDataGrid";
            SearchBookDataGrid.ReadOnly = true;
            SearchBookDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SearchBookDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            SearchBookDataGrid.RowTemplate.Height = 50;
            SearchBookDataGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            SearchBookDataGrid.Size = new Size(577, 308);
            SearchBookDataGrid.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.Info;
            BackBtn.Location = new Point(672, 389);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(116, 49);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "Book Search";
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BackBtn);
            Controls.Add(SearchBookDataGrid);
            Controls.Add(SearchBtn);
            Controls.Add(keywordText);
            Controls.Add(keywordLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBook";
            Text = "SearchBook";
            ((System.ComponentModel.ISupportInitialize)SearchBookDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label keywordLable;
        private TextBox keywordText;
        private Button SearchBtn;
        private DataGridView SearchBookDataGrid;
        private Button BackBtn;
        private Panel panel1;
        private Label label1;
    }
}