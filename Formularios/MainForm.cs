using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LoginSystem.Formularios
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Bem-Vindo(a), {Session.LoggedUser.Username}!";
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                BtnAdminPanel.Visible = true;
            }
            else
            {
                BtnAdminPanel.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedUser = null;
            this.Close();
            Application.Restart(); // Ou reabrir o LoginForm
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área administrativa (você pode listar usuários, etc.)");
            //Abrir um form de administração, etc.
        }
    }
}
