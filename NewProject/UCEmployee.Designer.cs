namespace NewProject
{
    partial class UCEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BtnSave = new Button();
            BtnClear = new Button();
            ComboTeam = new ComboBox();
            ComboPosition = new ComboBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            DGEmployee = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(BtnClear);
            groupBox1.Controls.Add(ComboTeam);
            groupBox1.Controls.Add(ComboPosition);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1217, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(598, 226);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(163, 47);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(421, 226);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(163, 47);
            BtnClear.TabIndex = 6;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // ComboTeam
            // 
            ComboTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboTeam.FormattingEnabled = true;
            ComboTeam.Location = new Point(41, 183);
            ComboTeam.Name = "ComboTeam";
            ComboTeam.Size = new Size(340, 36);
            ComboTeam.TabIndex = 2;
            ComboTeam.Text = "Select Teams";
            // 
            // ComboPosition
            // 
            ComboPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboPosition.FormattingEnabled = true;
            ComboPosition.Location = new Point(41, 140);
            ComboPosition.Name = "ComboPosition";
            ComboPosition.Size = new Size(340, 36);
            ComboPosition.TabIndex = 2;
            ComboPosition.Text = "Select Positions";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(421, 97);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Address";
            textBox5.Size = new Size(340, 122);
            textBox5.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(41, 97);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Age";
            textBox3.Size = new Size(340, 34);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(421, 54);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Phone No";
            textBox2.Size = new Size(340, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(41, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(340, 34);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(DGEmployee);
            groupBox2.Location = new Point(0, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1217, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee List";
            // 
            // DGEmployee
            // 
            DGEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            DGEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGEmployee.Dock = DockStyle.Fill;
            DGEmployee.Location = new Point(3, 28);
            DGEmployee.Name = "DGEmployee";
            DGEmployee.RowHeadersWidth = 51;
            DGEmployee.Size = new Size(1211, 293);
            DGEmployee.TabIndex = 0;
            // 
            // UCEmployee
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCEmployee";
            Size = new Size(1217, 697);
            Load += UCEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView DGEmployee;
        private ComboBox ComboPosition;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button BtnSave;
        private Button BtnClear;
        private ComboBox ComboTeam;
    }
}
