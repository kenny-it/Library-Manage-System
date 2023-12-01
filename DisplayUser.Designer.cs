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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DiaplayUserDataGrid = new DataGridView();
            BackBtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DiaplayUserDataGrid).BeginInit();
            SuspendLayout();
            // 
            // DiaplayUserDataGrid
            // 
            DiaplayUserDataGrid.AllowUserToAddRows = false;
            DiaplayUserDataGrid.AllowUserToDeleteRows = false;
            DiaplayUserDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DiaplayUserDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DiaplayUserDataGrid.BackgroundColor = Color.White;
            DiaplayUserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DiaplayUserDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DiaplayUserDataGrid.Location = new Point(27, 39);
            DiaplayUserDataGrid.Name = "DiaplayUserDataGrid";
            DiaplayUserDataGrid.ReadOnly = true;
            DiaplayUserDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DiaplayUserDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DiaplayUserDataGrid.RowTemplate.Height = 29;
            DiaplayUserDataGrid.Size = new Size(737, 299);
            DiaplayUserDataGrid.TabIndex = 0;
            DiaplayUserDataGrid.CellContentClick += DiaplayUserDataGrid_CellContentClick;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Maroon;
            BackBtn.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ButtonHighlight;
            BackBtn.Location = new Point(651, 382);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(113, 56);
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
            label2.Location = new Point(2, -4);
            label2.Name = "label2";
            label2.Size = new Size(249, 40);
            label2.TabIndex = 3;
            label2.Text = "Display User(s)";
            // 
            // DisplayUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(DiaplayUserDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayUser";
            Text = "DisplayUser";
            Load += DisplayUser_Load;
            ((System.ComponentModel.ISupportInitialize)DiaplayUserDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DiaplayUserDataGrid;
        private Button BackBtn;
        private Label label2;
    }
}