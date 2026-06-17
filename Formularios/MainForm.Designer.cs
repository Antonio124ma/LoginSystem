namespace LoginSystem.Formularios
{
    partial class MainForm
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
            BtnAdminPanel = new Button();
            BtnLogoutPanel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnAdminPanel
            // 
            BtnAdminPanel.Location = new Point(32, 142);
            BtnAdminPanel.Name = "BtnAdminPanel";
            BtnAdminPanel.Size = new Size(111, 54);
            BtnAdminPanel.TabIndex = 0;
            BtnAdminPanel.Text = "Admin";
            BtnAdminPanel.UseVisualStyleBackColor = true;
            BtnAdminPanel.Click += BtnAdmin_Click;
            // 
            // BtnLogoutPanel
            // 
            BtnLogoutPanel.Location = new Point(286, 142);
            BtnLogoutPanel.Name = "BtnLogoutPanel";
            BtnLogoutPanel.Size = new Size(119, 54);
            BtnLogoutPanel.TabIndex = 1;
            BtnLogoutPanel.Text = "Logout";
            BtnLogoutPanel.UseVisualStyleBackColor = true;
            BtnLogoutPanel.Click += BtnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(185, 54);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 232);
            Controls.Add(label1);
            Controls.Add(BtnLogoutPanel);
            Controls.Add(BtnAdminPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdminPanel;
        private Button BtnLogoutPanel;
        private Label label1;
    }
}