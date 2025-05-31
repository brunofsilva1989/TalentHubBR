using System.Windows.Forms;
using TalentHub.BLL.Services;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmUploadDocumentos : Form
    {
        private readonly BoCandidatoService _candidatoService;
        private readonly BoDocumentoService _documentoService = new BoDocumentoService(new TalentHubContext());
        private Form _formOrigem;
        public frmUploadDocumentos(Form formOrigem)
        {
            InitializeComponent();

            var context = new TalentHubContext();
            _candidatoService = new BoCandidatoService(context);
            _formOrigem = formOrigem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUploadDocumentos_Load(object sender, EventArgs e)
        {
            CarregarCandidatos();
            RecarregarGrid();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            SelecionarArquivo();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadDocumento();
        }

        #region Métodos Privados
        /// <summary>
        /// Método para enviar o documento do candidato.
        /// </summary>
        private void UploadDocumento()
        {
            if (cmbCandidato.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um candidato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtArquivo.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int candidatoId = (int)cmbCandidato.SelectedValue;
                string tipoDocumento = txtTipo.Text;
                string caminho = txtArquivo.Text;
                string nomeDocumento = System.IO.Path.GetFileName(caminho);
                byte[] conteudo = System.IO.File.ReadAllBytes(txtArquivo.Text);
                _documentoService.AdicionarDocumento(candidatoId, nomeDocumento, tipoDocumento, conteudo);
                MessageBox.Show("Documento enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar documento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para carregar os candidatos no ComboBox.
        /// </summary>
        private void CarregarCandidatos()
        {
            var candidatos = _candidatoService.ObterTodosCandidatos()
                .Where(c => c.Status == StatusCandidato.Ativo)
                .ToList();

            cmbCandidato.DataSource = null;
            cmbCandidato.DataSource = candidatos;
            cmbCandidato.DisplayMember = "Nome";
            cmbCandidato.ValueMember = "Id";

            cmbCandidato.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCandidato.SelectedIndex = -1;
        }

        /// <summary>
        /// Método para recarregar o DataGridView com os documentos do candidato selecionado.
        /// </summary>
        private void RecarregarGrid()
        {
            if (cmbCandidato.SelectedIndex != -1)
            {
                int candidatoId = (int)cmbCandidato.SelectedValue;
                var documentos = _documentoService.ObterDocumentosPorCandidato(candidatoId);
                dgvDocumentos.DataSource = documentos.Select(d => new
                {
                    d.Id,
                    d.Nome,
                    d.Tipo,
                    d.DataUpload
                }).ToList();
            }
        }

        /// <summary>
        /// Método para selecionar um arquivo PDF.
        /// </summary>
        private void SelecionarArquivo()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf|Todos os arquivos (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtArquivo.Text = openFileDialog.FileName;
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _formOrigem.Show();
            this.Close();
        }
    }
}