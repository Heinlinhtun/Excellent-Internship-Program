namespace NewProject
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            BtnEmployee = new Button();
            BtnAttend = new Button();
            BtnHome = new Button();
            PnlContainer = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(202, 244, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(248, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 94);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(202, 244, 255);
            panel2.Controls.Add(BtnEmployee);
            panel2.Controls.Add(BtnAttend);
            panel2.Controls.Add(BtnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 784);
            panel2.TabIndex = 0;
            // 
            // BtnEmployee
            // 
            BtnEmployee.BackColor = Color.FromArgb(90, 178, 255);
            BtnEmployee.FlatAppearance.BorderColor = Color.FromArgb(90, 178, 255);
            BtnEmployee.FlatStyle = FlatStyle.Flat;
            BtnEmployee.ForeColor = SystemColors.Control;
            BtnEmployee.Location = new Point(3, 169);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(242, 69);
            BtnEmployee.TabIndex = 0;
            BtnEmployee.Text = "Employee";
            BtnEmployee.UseVisualStyleBackColor = false;
            BtnEmployee.Click += BtnEmployee_Click;
            // 
            // BtnAttend
            // 
            BtnAttend.BackColor = Color.FromArgb(90, 178, 255);
            BtnAttend.FlatAppearance.BorderColor = Color.FromArgb(90, 178, 255);
            BtnAttend.FlatStyle = FlatStyle.Flat;
            BtnAttend.ForeColor = SystemColors.Control;
            BtnAttend.Location = new Point(3, 244);
            BtnAttend.Name = "BtnAttend";
            BtnAttend.Size = new Size(242, 69);
            BtnAttend.TabIndex = 0;
            BtnAttend.Text = "Attendence";
            BtnAttend.UseVisualStyleBackColor = false;
            BtnAttend.Click += BtnAttend_Click;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.FromArgb(90, 178, 255);
            BtnHome.FlatAppearance.BorderColor = Color.FromArgb(90, 178, 255);
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.ForeColor = SystemColors.Control;
            BtnHome.Location = new Point(3, 94);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(242, 69);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // PnlContainer
            // 
            PnlContainer.Dock = DockStyle.Fill;
            PnlContainer.Location = new Point(248, 94);
            PnlContainer.Name = "PnlContainer";
            PnlContainer.Size = new Size(1033, 690);
            PnlContainer.TabIndex = 1;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 784);
            Controls.Add(PnlContainer);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnHome;
        private Panel PnlContainer;
        private Button BtnEmployee;
        private Button BtnAttend;
    }
}
