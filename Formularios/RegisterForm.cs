using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.Contexto;
using LoginSystem.Models;

namespace LoginSystem.Formularios
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadRoles();
        }
        private void LoadRoles()
        {
            using var db = new AppDbContext();
            var roles = db.Roles.ToList();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string email = TxtEmail.Text.Trim();
            string password = TxtPassword.Text;
            string confirm = TxtConfirm.Text;
            string selectrole = (cmbRole.SelectedItem as Role)?.Name;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("As senhas não são iguais");
                return;
            }
            bool sucess = AuthService.RegisterUser(username, email, password, selectrole);
            if (sucess)
            {
                MessageBox.Show("Usuário já cadastrado com sucesso! Faça login.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuário e email já existente.");
            }

        }
    }
}
