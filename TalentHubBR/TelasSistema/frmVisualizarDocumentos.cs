using System.Data;
using System.Xml.Serialization;
using TalentHub.BLL.Services;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmVisualizarDocumentos : Form
    {
        private readonly BoDocumentoService _documentoService = new BoDocumentoService(new TalentHub.DAL.TalentHubContext());
        private readonly BoCandidatoService _candidatoService;
        private bool _carregarCombo = false;
        private Form _formOrigem;
        public frmVisualizarDocumentos(Form formOrigem)
        {
            InitializeComponent();

            var context = new TalentHub.DAL.TalentHubContext();
            _candidatoService = new BoCandidatoService(context);
            _formOrigem = formOrigem;
        }

        #region Eventos do Formulário

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCandidato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_carregarCombo)
            {
                CarregarDocumentos();
            }
        }

        private void btnVerDoc_Click(object sender, EventArgs e)
        {
            ViewDoc();
        }

        private void frmVisualizarDocumentos_Load(object sender, EventArgs e)
        {
            CarregarCandidatos();
            //RecarregarGrid();
        }
        #endregion


        #region Métodos Privados

        private void CarregarDocumentos()
        {
            if (cmbCandidato.SelectedIndex != -1)
            {
                int candidatoId = Convert.ToInt32(cmbCandidato.SelectedValue);
                var documentos = _documentoService.ObterDocumentosPorCandidato(candidatoId);
                dgvDocumentos.DataSource = null;
                dgvDocumentos.Rows.Clear();
                foreach (var doc in documentos)
                {
                    dgvDocumentos.Columns.Add("Id", "Id");
                    dgvDocumentos.Columns.Add("Nome", "Nome");
                    dgvDocumentos.Columns.Add("Tipo", "Tipo");
                    dgvDocumentos.Columns.Add("DataUpload", "Data Upload");
                    dgvDocumentos.Rows.Add(doc.Id, doc.Nome, doc.Tipo, doc.DataUpload);
                }
                dgvDocumentos.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um candidato para visualizar os documentos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CarregarCandidatos()
        {
            _carregarCombo = true;

            var candidatos = _candidatoService.ObterTodosCandidatos()
                .Where(c => c.Status == StatusCandidato.Ativo)
                .ToList();

            cmbCandidato.DataSource = null;
            cmbCandidato.DataSource = candidatos;
            cmbCandidato.DisplayMember = "Nome";
            cmbCandidato.ValueMember = "Id";

            cmbCandidato.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCandidato.SelectedIndex = -1;

            _carregarCombo = false;
        }

        private void ViewDoc()
        {
            if (dgvDocumentos.SelectedRows.Count > 0)
            {
                int documentoId = Convert.ToInt32(dgvDocumentos.SelectedRows[0].Cells["Id"].Value);
                var base64Content = _documentoService.ObterDocumentoPorId(documentoId);
                byte[] content = Convert.FromBase64String(base64Content);

                string caminhoTemp = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "documento_temp.pdf");
                File.WriteAllBytes(caminhoTemp, content);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = caminhoTemp,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Por favor, selecione um documento antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecarregarGrid()
        {
            dgvDocumentos.DataSource = null;
            dgvDocumentos.Rows.Clear();
            CarregarDocumentos();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _formOrigem.Show(); // Mostra o formulário de origem
            this.Close(); // Fecha o formulário atual
        }
    }
}
