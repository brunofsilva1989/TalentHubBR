using TalentHub.BLL.Services;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmRelatorio : Form
    {
        #region Propriedades Privadas
        private readonly BoCandidatoService _candidatoService;
        private readonly BoEmpresaService _empresaService;
        private readonly BoVagaService _vagaService;
        private readonly BoRelatorioService _relatorioService;
        private readonly BoFeedbackService _feedbackService;
        private int _candidatoIdSelecionado = 0;
        private bool _carregarTodosCandidatos = false;
        private bool _selecaoRelatorio = true;
        private bool _formCarregado = false;
        private Form _formOrigem;
        #endregion

        public frmRelatorio(Form formOrigem)
        {
            InitializeComponent();
            _candidatoService = new BoCandidatoService(new TalentHub.DAL.TalentHubContext());
            _empresaService = new BoEmpresaService(new TalentHub.DAL.TalentHubContext());
            _vagaService = new BoVagaService(new TalentHub.DAL.TalentHubContext());
            _relatorioService = new BoRelatorioService(new TalentHub.DAL.TalentHubContext());
            _feedbackService = new BoFeedbackService(new TalentHub.DAL.TalentHubContext());

            cmbTipoRelatorio.SelectedIndexChanged += cmbTipoRelatorio_SelectedIndexChanged;
            TipoRelatorio();
            _formOrigem = formOrigem;
        }

        #region Eventos do Formulário
        private void cmbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formCarregado || cmbTipoRelatorio.SelectedIndex <= 0)
                return;

            var tipo = cmbTipoRelatorio.SelectedItem.ToString();
            if (tipo == "Selecione")
            {
                MessageBox.Show("Por favor, selecione um tipo de relatório válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CarregarComboSelecionado(tipo);
            dgvRelatorios.DataSource = null;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            AcaoGerarRelatorio();
        }

        private void dgvRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void a_Load(object sender, EventArgs e)
        {
            TipoRelatorio();
            _formCarregado = true;
            cmbTipoRelatorio.SelectedIndex = 0;
        }

        private void cmbSelecionado_SelectedIndexChanged(object sender, EventArgs e)
        {

            //AcaoGerarRelatorio();
        }
        #endregion

        #region Métodos Privados        
        private void TipoRelatorio()
        {
            cmbTipoRelatorio.Items.Clear();
            cmbTipoRelatorio.Items.Add("Selecione");
            cmbTipoRelatorio.Items.Add("Candidatos");
            cmbTipoRelatorio.Items.Add("Empresas");
            cmbTipoRelatorio.Items.Add("Vagas");
            cmbTipoRelatorio.Items.Add("Feedbacks");
            cmbTipoRelatorio.SelectedIndex = 0; // Seleciona o primeiro item por padrão            
        }

        private void AcaoGerarRelatorio()
        {
            if (cmbTipoRelatorio.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor, selecione um tipo de relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSelecionado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um item ou a opção 'Geral'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = cmbTipoRelatorio.SelectedItem.ToString();
            string itemSelecionado = cmbSelecionado.SelectedItem.ToString();
            bool gerarTodos = itemSelecionado == "Geral";
            //selecionar o id quando for individual feedback
            var idSelecionado = 0;

            switch (tipo)
            {
                case "Candidatos":
                    if (gerarTodos)
                        RelatorioCandidatos(true);
                    else
                        RelatorioCandidatos(false);
                    break;
                case "Empresas":
                    if (gerarTodos)
                        RelatorioEmpresas(true);
                    else
                        RelatorioEmpresas(false);
                    break;
                case "Vagas":
                    if (gerarTodos)
                        RelatorioVagas(true);
                    else
                        RelatorioVagas(false);
                    break;
                case "Feedbacks":
                    if (gerarTodos)
                        RelatorioFeedbacks(true);
                    else
                        RelatorioFeedbacks(false);
                    break;
                default:
                    MessageBox.Show("Por favor, selecione um tipo de relatório válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void CarregarComboSelecionado(string tipo)
        {
            cmbSelecionado.Items.Clear();
            cmbSelecionado.Items.Add("Geral");

            switch (tipo)
            {
                case "Candidatos":
                    var candidatos = _candidatoService.ObterTodosCandidatos();
                    foreach (var c in candidatos)
                        cmbSelecionado.Items.Add(c);
                    break;
                case "Empresas":
                    var empresas = _empresaService.ObterTodasEmpresas();
                    foreach (var e in empresas)
                        cmbSelecionado.Items.Add(e);
                    break;
                case "Vagas":
                    var vagas = _vagaService.ObterTodasVagas();
                    foreach (var v in vagas)
                        cmbSelecionado.Items.Add(v);
                    break;
                case "Feedbacks":
                    var feedback = _feedbackService.ObterTodosFeedbacks();
                    foreach (var f in feedback)
                        cmbSelecionado.Items.Add(f);
                    break;
            }
        }

        private void RelatorioCandidatos(bool selecaoRelatorio = false)
        {
            var itemSelecionado = cmbSelecionado.SelectedItem;

            try
            {
                // Valida se é relatório Geral  
                if (selecaoRelatorio || itemSelecionado is string geral && geral == "Geral")
                {
                    _relatorioService.GerarRelatorioCandidatosGeral("C:\\Relatórios\\rel_geral_candidatos.pdf");
                    MessageBox.Show("Relatório dod candidatos gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Se não for relatório Geral, gera relatório individual
                if (itemSelecionado is Candidato candidato)
                {
                    _relatorioService.GerarRelatorioCandidatoIndividual(candidato.Id, "C:\\Relatórios\\rel_candidato.pdf");
                    MessageBox.Show($"Relatório do candidato {candidato.Nome} gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um candidato válido para gerar o relatório individual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }


        private void RelatorioEmpresas(bool selecaoRelatorio = true)
        {
            _candidatoIdSelecionado = Convert.ToInt32(cmbSelecionado.SelectedValue);
            if (selecaoRelatorio)
            {
                // Implementar lógica para gerar relatório de empresas
                _relatorioService.GerarRelatorioCandidatosGeral("C:\\Relatórios\\rel_geral_empresa.pdf");
                MessageBox.Show("Relatório de empresas gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Implementar lógica para gerar relatório de empresas individual
                _relatorioService.GerarRelatorioEmpresasIndividual(_candidatoIdSelecionado, "C:\\Relatórios\\rel_empresa.pdf");
                MessageBox.Show("Relatório de empresa individual gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RelatorioVagas(bool selecaoRelatorio = true)
        {
            _candidatoIdSelecionado = Convert.ToInt32(cmbSelecionado.SelectedValue);
            if (selecaoRelatorio)
            {
                // Implementar lógica para gerar relatório de vagas
                _relatorioService.GerarRelatorioVagasGeral("C:\\Relatórios\\rel_geral_vagas.pdf");
                MessageBox.Show("Relatório de vagas gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Implementar lógica para gerar relatório de vaga individual
                _relatorioService.GerarRelatorioVagaIndividual(_candidatoIdSelecionado, "C:\\Relatórios\\rel_vaga.pdf");
                MessageBox.Show("Relatório de vaga individual gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RelatorioFeedbacks(bool selecaoRelatorio = true)
        {
            var itemSelecionado = cmbSelecionado.SelectedItem;

            try
            {
                if (selecaoRelatorio || itemSelecionado is string geral && geral == "Geral")
                {
                    _relatorioService.GerarRelatorioFeedbacksGeral("C:\\Relatórios\\rel_geral_feedbacks.pdf");
                    MessageBox.Show("Relatório de feedbacks gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (itemSelecionado is Feedback feedback)
                {

                    var idFeedback = feedback.CandidatoId;
                    var idCandidato = feedback.CandidatoId;

                    _relatorioService.GerarRelatorioFeedbackIndividual(idFeedback, idCandidato, "C:\\Relatórios\\rel_feedback.pdf");
                    MessageBox.Show("Relatório de feedback individual gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {            
            _formOrigem.Show(); // Exibe o formulário de origem
            this.Close(); // Fecha o formulário atual
        }
    }
}
