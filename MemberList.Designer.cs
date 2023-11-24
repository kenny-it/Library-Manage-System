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
            MemberListView = new DataGridView();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberListView).BeginInit();
            SuspendLayout();
            // 
            // MemberListView
            // 
            MemberListView.BackgroundColor = Color.White;
            MemberListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberListView.Location = new Point(12, 87);
            MemberListView.Name = "MemberListView";
            MemberListView.RowTemplate.Height = 25;
            MemberListView.Size = new Size(933, 406);
            MemberListView.TabIndex = 0;
            // 
            // Back
            // 
            Back.Location = new Point(833, 521);
            Back.Name = "Back";
            Back.Size = new Size(112, 43);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 245);
            ClientSize = new Size(957, 566);
            Controls.Add(Back);
            Controls.Add(MemberListView);
            Name = "MemberList";
            Text = "MemberList";
            Load += MemberList_Load;
            ((System.ComponentModel.ISupportInitialize)MemberListView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MemberListView;
        private Button Back;
    }
}