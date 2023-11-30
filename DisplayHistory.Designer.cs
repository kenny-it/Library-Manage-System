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
            HistoryDataGrid = new DataGridView();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // HistoryDataGrid
            // 
            HistoryDataGrid.AllowUserToAddRows = false;
            HistoryDataGrid.AllowUserToDeleteRows = false;
            HistoryDataGrid.BackgroundColor = Color.White;
            HistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryDataGrid.Location = new Point(38, 48);
            HistoryDataGrid.Name = "HistoryDataGrid";
            HistoryDataGrid.ReadOnly = true;
            HistoryDataGrid.RowHeadersWidth = 51;
            HistoryDataGrid.RowTemplate.Height = 29;
            HistoryDataGrid.Size = new Size(717, 299);
            HistoryDataGrid.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(586, 384);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // DisplayHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(HistoryDataGrid);
            Name = "DisplayHistory";
            Text = "DisplayHistory";
            Load += DisplayHistory_Load;
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistoryDataGrid;
        private Button BackBtn;
    }
}