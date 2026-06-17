namespace LoginSystem.Formularios
{
    partial class RegisterForm
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
            cmbRole = new ComboBox();
            label1 = new Label();
            TxtUsername = new TextBox();
            btnRegister = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtEmail = new TextBox();
            TxtPassword = new TextBox();
            TxtConfirm = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(123, 42);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(199, 23);
            cmbRole.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 86);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(123, 83);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(199, 23);
            TxtUsername.TabIndex = 2;
            TxtUsername.TextChanged += textBox1_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(196, 245);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(126, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 204);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Confirm:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(123, 118);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(199, 23);
            TxtEmail.TabIndex = 2;
            TxtEmail.TextChanged += textBox1_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(123, 157);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(199, 23);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.TextChanged += textBox1_TextChanged;
            // 
            // TxtConfirm
            // 
            TxtConfirm.Location = new Point(123, 201);
            TxtConfirm.Name = "TxtConfirm";
            TxtConfirm.Size = new Size(199, 23);
            TxtConfirm.TabIndex = 2;
            TxtConfirm.UseSystemPasswordChar = true;
            TxtConfirm.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 121);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 45);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "Select Role:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 291);
            Controls.Add(btnRegister);
            Controls.Add(TxtConfirm);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(TxtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRole;
        private Label label1;
        private TextBox TxtUsername;
        private Button btnRegister;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtEmail;
        private TextBox TxtPassword;
        private TextBox TxtConfirm;
        private Label label5;
        private Label label6;
    }
}