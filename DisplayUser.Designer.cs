namespace Library_Manage_System
{
    partial class DisplayUser
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
            DiaplayUserDataGrid = new DataGridView();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DiaplayUserDataGrid).BeginInit();
            SuspendLayout();
            // 
            // DiaplayUserDataGrid
            // 
            DiaplayUserDataGrid.AllowUserToAddRows = false;
            DiaplayUserDataGrid.AllowUserToDeleteRows = false;
            DiaplayUserDataGrid.BackgroundColor = Color.White;
            DiaplayUserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiaplayUserDataGrid.Location = new Point(27, 39);
            DiaplayUserDataGrid.Name = "DiaplayUserDataGrid";
            DiaplayUserDataGrid.ReadOnly = true;
            DiaplayUserDataGrid.RowHeadersWidth = 51;
            DiaplayUserDataGrid.RowTemplate.Height = 29;
            DiaplayUserDataGrid.Size = new Size(737, 299);
            DiaplayUserDataGrid.TabIndex = 0;
            DiaplayUserDataGrid.CellContentClick += DiaplayUserDataGrid_CellContentClick;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(605, 368);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(113, 56);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // DisplayUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(DiaplayUserDataGrid);
            Name = "DisplayUser";
            Text = "DisplayUser";
            Load += DisplayUser_Load;
            ((System.ComponentModel.ISupportInitialize)DiaplayUserDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DiaplayUserDataGrid;
        private Button BackBtn;
    }
}