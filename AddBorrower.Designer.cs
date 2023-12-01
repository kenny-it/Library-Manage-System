namespace Library_Manage_System
{
    partial class AddBorrower
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
            firstLable = new Label();
            LastLabel = new Label();
            ContactLabel = new Label();
            AddB_FName = new TextBox();
            AddB_LName = new TextBox();
            AddB_CNumber = new TextBox();
            AddB_Reset = new Button();
            AddB_Enter = new Button();
            SuspendLayout();
            // 
            // firstLable
            // 
            firstLable.AutoSize = true;
            firstLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstLable.Location = new Point(138, 80);
            firstLable.Name = "firstLable";
            firstLable.Size = new Size(115, 28);
            firstLable.TabIndex = 0;
            firstLable.Text = "First Name :";
            // 
            // LastLabel
            // 
            LastLabel.AutoSize = true;
            LastLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastLabel.Location = new Point(142, 139);
            LastLabel.Name = "LastLabel";
            LastLabel.Size = new Size(112, 28);
            LastLabel.TabIndex = 1;
            LastLabel.Text = "Last Name :";
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactLabel.Location = new Point(86, 203);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(166, 28);
            ContactLabel.TabIndex = 2;
            ContactLabel.Text = "Contact Number :";
            // 
            // AddB_FName
            // 
            AddB_FName.Location = new Point(255, 82);
            AddB_FName.Name = "AddB_FName";
            AddB_FName.Size = new Size(125, 27);
            AddB_FName.TabIndex = 3;
            AddB_FName.TextChanged += AddB_FName_TextChanged;
            // 
            // AddB_LName
            // 
            AddB_LName.Location = new Point(255, 141);
            AddB_LName.Name = "AddB_LName";
            AddB_LName.Size = new Size(125, 27);
            AddB_LName.TabIndex = 4;
            // 
            // AddB_CNumber
            // 
            AddB_CNumber.Location = new Point(255, 206);
            AddB_CNumber.Name = "AddB_CNumber";
            AddB_CNumber.Size = new Size(125, 27);
            AddB_CNumber.TabIndex = 5;
            // 
            // AddB_Reset
            // 
            AddB_Reset.BackColor = Color.Maroon;
            AddB_Reset.FlatStyle = FlatStyle.Popup;
            AddB_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddB_Reset.ForeColor = Color.White;
            AddB_Reset.Location = new Point(255, 314);
            AddB_Reset.Name = "AddB_Reset";
            AddB_Reset.Size = new Size(94, 44);
            AddB_Reset.TabIndex = 6;
            AddB_Reset.Text = "Reset";
            AddB_Reset.UseVisualStyleBackColor = false;
            AddB_Reset.Click += AddB_Reset_Click;
            // 
            // AddB_Enter
            // 
            AddB_Enter.BackColor = Color.Maroon;
            AddB_Enter.FlatStyle = FlatStyle.Popup;
            AddB_Enter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddB_Enter.ForeColor = SystemColors.Info;
            AddB_Enter.Location = new Point(455, 314);
            AddB_Enter.Name = "AddB_Enter";
            AddB_Enter.Size = new Size(94, 44);
            AddB_Enter.TabIndex = 7;
            AddB_Enter.Text = "Enter";
            AddB_Enter.UseVisualStyleBackColor = false;
            AddB_Enter.Click += AddB_Enter_Click;
            // 
            // AddBorrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 412);
            Controls.Add(AddB_Enter);
            Controls.Add(AddB_Reset);
            Controls.Add(AddB_CNumber);
            Controls.Add(AddB_LName);
            Controls.Add(AddB_FName);
            Controls.Add(ContactLabel);
            Controls.Add(LastLabel);
            Controls.Add(firstLable);
            Name = "AddBorrower";
            Text = "AddBorrower";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstLable;
        private Label LastLabel;
        private Label ContactLabel;
        private TextBox AddB_FName;
        private TextBox AddB_LName;
        private TextBox AddB_CNumber;
        private Button AddB_Reset;
        private Button AddB_Enter;
    }
}