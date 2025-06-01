using TalentHubBR.UI.TelasSistema;

namespace TalentHubBR.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        #region Eventos do Formulário
        private void cadastrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Pass 'this' as the required 'formOrigem' parameter to the constructor  
            frmCadastroEmpresa form = new frmCadastroEmpresa(this);
            form.ShowDialog(); // Show the form as a modal dialog  


        }

        private void cadastrarVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVaga form = new frmCadastroVaga(this);
            form.ShowDialog();


        }

        private void cadastrarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCandidato frm = new frmCadastroCandidato(this);
            frm.ShowDialog();
        }

        private void uploadDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUploadDocumentos form = new frmUploadDocumentos(this);
            form.ShowDialog();


        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio form = new frmRelatorio(this);
            form.ShowDialog();


        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda form = new frmAjuda();
            form.ShowDialog();
        }

        private void visualizarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarDocumentos form = new frmVisualizarDocumentos(this);
            form.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorio form = new frmRelatorio(this);
            form.ShowDialog();
        }

        private void bancoDeTalentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBancoTalentos form = new frmBancoTalentos(this);
            form.ShowDialog();
        }
    }

}

