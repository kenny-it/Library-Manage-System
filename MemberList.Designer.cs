namespace Library_Manage_System
{
    partial class MemberList
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
            MemberListView = new DataGridView();
            Back = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MemberListView).BeginInit();
            SuspendLayout();
            // 
            // MemberListView
            // 
            MemberListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MemberListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MemberListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MemberListView.BackgroundColor = Color.White;
            MemberListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MemberListView.DefaultCellStyle = dataGridViewCellStyle1;
            MemberListView.Location = new Point(14, 116);
            MemberListView.Margin = new Padding(3, 4, 3, 4);
            MemberListView.Name = "MemberListView";
            MemberListView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MemberListView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            MemberListView.RowTemplate.Height = 25;
            MemberListView.Size = new Size(1066, 541);
            MemberListView.TabIndex = 0;
            // 
            // Back
            // 
            Back.BackColor = Color.Transparent;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(943, 685);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(128, 57);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(198, 74);
            label1.TabIndex = 2;
            label1.Text = "Group 2\r\nMember List";
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Maroon;
            ClientSize = new Size(1094, 755);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(MemberListView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MemberList";
            Load += MemberList_Load;
            ((System.ComponentModel.ISupportInitialize)MemberListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MemberListView;
        private Button Back;
        private Label label1;
    }
}