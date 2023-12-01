namespace Library_Manage_System
{
    partial class DisplayHistory
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
            HistoryDataGrid = new DataGridView();
            BackBtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // HistoryDataGrid
            // 
            HistoryDataGrid.AllowUserToAddRows = false;
            HistoryDataGrid.AllowUserToDeleteRows = false;
            HistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            HistoryDataGrid.BackgroundColor = Color.White;
            HistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            HistoryDataGrid.Location = new Point(38, 48);
            HistoryDataGrid.Name = "HistoryDataGrid";
            HistoryDataGrid.ReadOnly = true;
            HistoryDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HistoryDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            HistoryDataGrid.RowTemplate.Height = 29;
            HistoryDataGrid.Size = new Size(717, 299);
            HistoryDataGrid.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackBtn.BackColor = Color.Maroon;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(649, 384);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(106, 54);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(341, 40);
            label2.TabIndex = 2;
            label2.Text = "Display Login History";
            // 
            // DisplayHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(HistoryDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayHistory";
            Text = "DisplayHistory";
            Load += DisplayHistory_Load;
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HistoryDataGrid;
        private Button BackBtn;
        private Label label2;
    }
}