namespace LoginSystem.Formularios
{
    partial class LoginForm
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
            TxtUsername = new TextBox();
            label1 = new Label();
            BtnLogin = new Button();
            label2 = new Label();
            TxtPassword = new TextBox();
            LnkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(141, 32);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(249, 23);
            TxtUsername.TabIndex = 0;
            TxtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "User:";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(141, 148);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(141, 82);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(249, 23);
            TxtPassword.TabIndex = 0;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.TextChanged += textBox1_TextChanged;
            // 
            // LnkRegister
            // 
            LnkRegister.AutoSize = true;
            LnkRegister.Location = new Point(319, 152);
            LnkRegister.Name = "LnkRegister";
            LnkRegister.Size = new Size(71, 15);
            LnkRegister.TabIndex = 3;
            LnkRegister.TabStop = true;
            LnkRegister.Text = "LinkRegister";
            LnkRegister.LinkClicked += LnkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 197);
            Controls.Add(LnkRegister);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsername;
        private Label label1;
        private Button BtnLogin;
        private Label label2;
        private TextBox TxtPassword;
        private LinkLabel LnkRegister;
    }
}