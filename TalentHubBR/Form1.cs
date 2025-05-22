using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHubBR.UI.TelasSistema;

namespace TalentHubBR.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Ensure frmCadastroEmpresa inherits from Form to use ShowDialog
            frmCadastroEmpresa form = new frmCadastroEmpresa();
            form.ShowDialog();
        }

        private void cadastrarVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVaga form = new frmCadastroVaga();
            form.ShowDialog();
        }

        private void cadastrarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCandidato form = new frmCadastroCandidato();
            form.ShowDialog();
        }

        private void uploadDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUploadDocumentos form = new frmUploadDocumentos();
            form.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios form = new frmRelatorios();
            form.ShowDialog();
        }

        private void bancoDeTalentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBancoTalentos form = new frmBancoTalentos();
            form.ShowDialog();
        }
    }
      
}

