using System.Windows.Forms;
using TalentHub.BLL.Services;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmCadastroVaga : Form
    {
        #region Propriedades Privadas
        private readonly BoVagaService _vagaService;
        private readonly BoEmpresaService _empresaService;
        private int _vagaIdSelecionada = 0;
        private Form _formOrigem;
        #endregion


        public frmCadastroVaga(Form formOrigem)
        {
            InitializeComponent();

            var context = new TalentHub.DAL.TalentHubContext();
            _vagaService = new BoVagaService(context);
            _empresaService = new BoEmpresaService(context);
            CarregarEmpresas();
            _formOrigem = formOrigem;
        }

        #region Eventos do Formulário
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarVaga(Convert.ToInt32(dgvVagas.CurrentRow.Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirVaga(Convert.ToInt32(dgvVagas.CurrentRow.Cells[0].Value));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparForumalario();
        }

        private void dgvVagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecarregaGridAposCriarDado();
        }

        private void frmCadastroVaga_Load(object sender, EventArgs e)
        {
            RecarregaGridAposCriarDado();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var vaga = new Vaga
            {
                Id = _vagaIdSelecionada,
                Descricao = txtDescricao.Text,
                EscopoVaga = txtEscopoVaga.Text,
                Status = (StatusVaga)Enum.Parse(typeof(StatusVaga), cmbStatus.Text),
                Cargo = txtCargo.Text,
                Salario = decimal.Parse(txtSalario.Text),
                DataAbertura = dtpDataAbertura.Value,
                DataExpiracao = dtpDataExpiracao.Value,
                EmpresaId = (int)cmbEmpresa.SelectedValue
            };

            try
            {
                if (_vagaIdSelecionada == 0)
                {
                    _vagaService.AdicionarVaga(vaga);
                    MessageBox.Show("Vaga cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _vagaService.AtualizarVaga(vaga);
                    MessageBox.Show("Vaga atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar vaga: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RecarregaGridAposCriarDado();
            }
        }
        #endregion

        #region Métodos auxiliares
        private void LimparForumalario()
        {
            txtDescricao.Clear();
            txtEscopoVaga.Clear();
            cmbStatus.SelectedIndex = -1;
            txtCargo.Clear();
            txtSalario.Clear();
            dtpDataAbertura.Value = DateTime.Now;
            dtpDataExpiracao.Value = DateTime.Now.AddDays(30);
            cmbEmpresa.SelectedIndex = -1;
            _vagaIdSelecionada = 0;
        }

        private void RecarregaGridAposCriarDado()
        {
            dgvVagas.DataSource = null;
            dgvVagas.Rows.Clear();
            CarregarVagas();
        }

        private void EditarVaga(int vagaId)
        {
            try
            {
                var vaga = _vagaService.ObterVagaPorId(vagaId);
                if (vaga != null)
                {
                    _vagaIdSelecionada = vaga.Id;
                    txtDescricao.Text = vaga.Descricao;
                    txtEscopoVaga.Text = vaga.EscopoVaga;
                    cmbStatus.Text = vaga.Status.ToString();
                    txtCargo.Text = vaga.Cargo;
                    txtSalario.Text = vaga.Salario.ToString("F2");
                    dtpDataAbertura.Value = vaga.DataAbertura;
                    dtpDataExpiracao.Value = vaga.DataExpiracao;
                    cmbEmpresa.SelectedValue = vaga.EmpresaId;
                }
                else
                {
                    MessageBox.Show("Vaga não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados da vaga: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RecarregaGridAposCriarDado();
            }
        }

        private void ExcluirVaga(int vagaId)
        {
            try
            {
                _vagaService.DeletarVaga(vagaId);
                MessageBox.Show("Vaga excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecarregaGridAposCriarDado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir vaga: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarVagas()
        {
            try
            {
                var vagas = _vagaService.ObterTodasVagas().ToList();

                var vagasNoGrid = vagas.Select(v => new
                {
                    v.Id,
                    v.Descricao,
                    v.EscopoVaga,
                    Status = v.Status.ToString(),
                    v.Cargo,
                    Salario = v.Salario.ToString("F2"),
                    DataAbertura = v.DataAbertura.ToShortDateString(),
                    DataExpiracao = v.DataExpiracao.ToShortDateString(),
                    Empresa = v.Empresa != null ? v.Empresa.Nome : ""
                }).ToList();

                dgvVagas.DataSource = vagasNoGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarEmpresas()
        {
            try
            {
                var empresas = _empresaService.ObterTodasEmpresas().ToList();

                cmbEmpresa.DataSource = empresas;
                cmbEmpresa.DisplayMember = "Nome";
                cmbEmpresa.ValueMember = "Id";
                cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;

                if (empresas.Count > 0)
                    cmbEmpresa.SelectedIndex = 0;  // Para garantir visualização
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _formOrigem.Show();
            this.Close(); // Fecha o formulário atual
        }
    }
}
