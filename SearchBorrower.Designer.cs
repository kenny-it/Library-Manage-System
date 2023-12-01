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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            borrowerIDLabel = new Label();
            SearchBtn = new Button();
            BorrowerDetailDataGrid = new DataGridView();
            BackBtn = new Button();
            BorrowerIDText = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BorrowerDetailDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borrowerIDLabel.Location = new Point(12, 90);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new Size(125, 28);
            borrowerIDLabel.TabIndex = 0;
            borrowerIDLabel.Text = "Borrower ID: ";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Maroon;
            SearchBtn.Font = new Font("Ink Free", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = SystemColors.HighlightText;
            SearchBtn.Location = new Point(12, 198);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(139, 57);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BorrowerDetailDataGrid
            // 
            BorrowerDetailDataGrid.AllowUserToAddRows = false;
            BorrowerDetailDataGrid.AllowUserToDeleteRows = false;
            BorrowerDetailDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BorrowerDetailDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BorrowerDetailDataGrid.BackgroundColor = Color.White;
            BorrowerDetailDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BorrowerDetailDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            BorrowerDetailDataGrid.Location = new Point(272, 58);
            BorrowerDetailDataGrid.Name = "BorrowerDetailDataGrid";
            BorrowerDetailDataGrid.ReadOnly = true;
            BorrowerDetailDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BorrowerDetailDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            BorrowerDetailDataGrid.RowTemplate.Height = 29;
            BorrowerDetailDataGrid.Size = new Size(516, 330);
            BorrowerDetailDataGrid.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(673, 394);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(115, 44);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // BorrowerIDText
            // 
            BorrowerIDText.Location = new Point(12, 131);
            BorrowerIDText.Name = "BorrowerIDText";
            BorrowerIDText.Size = new Size(183, 27);
            BorrowerIDText.TabIndex = 5;
            BorrowerIDText.TextChanged += BorrowerIDText_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Borrower Search";
            // 
            // SearchBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BorrowerIDText);
            Controls.Add(BackBtn);
            Controls.Add(BorrowerDetailDataGrid);
            Controls.Add(SearchBtn);
            Controls.Add(borrowerIDLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBorrower";
            Text = "SearchBorrower";
            ((System.ComponentModel.ISupportInitialize)BorrowerDetailDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label borrowerIDLabel;
        private Button SearchBtn;
        private DataGridView BorrowerDetailDataGrid;
        private Button BackBtn;
        private TextBox BorrowerIDText;
        private Panel panel1;
        private Label label1;
    }
}