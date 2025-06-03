using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //var usuarioValido = _usuarioService.Autenticar(usuario, senha);
            //if (usuarioValido != null)
            //{
            //    // login...
            //}


            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Ana Paula" && password == "Ana123")
            {
                CustomMessageBox.Show("Login bem-sucedido!");
                this.DialogResult = DialogResult.OK; // Define o resultado do diálogo como OK
                this.Hide();

                var telaPrincipal = new Form1(); // Cria uma nova instância do formulário principal
                telaPrincipal.Show(); // Exibe o formulário principal                
            }
            else
            {
                CustomMessageBox.Show("Usuário ou senha inválidos. Tente novamente.");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Simula o clique no botão de login quando a tecla Enter é pressionada
            }
        }
    }
}
