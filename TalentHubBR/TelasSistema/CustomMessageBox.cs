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
    public partial class CustomMessageBox : Form
    {
        private string titulo;
        private string mensagem;

        public CustomMessageBox(string mensagem, string titulo = "Mensagem")
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensagem = mensagem;
            this.Text = this.titulo;
            lblMensagem.Text = this.mensagem;
        }

        public static void Show(string mensagem, string titulo = "Mensagem")
        {
            var msg = new CustomMessageBox(mensagem, titulo);
            msg.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {
            var msg = new CustomMessageBox("Mensagem de teste", "Título de teste");
        }
    }
}
