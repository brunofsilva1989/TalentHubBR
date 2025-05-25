using Microsoft.Extensions.Logging;
using TalentHub.BLL.Services;
using TalentHub.DAL;
using TalentHub.Domain.Entities;
using TalentHub.Infra;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmCadastroCandidato : Form
    {
        #region Propriedades Privadas
        private readonly BoCandidatoService _candidatoService;
        private int _candidatoIdSelecionado = 0;
        private readonly ILogger<frmCadastroCandidato> logger = LoggerConfig.CreateLogger<frmCadastroCandidato>();
        #endregion

        public frmCadastroCandidato()
        {
            InitializeComponent();

            var context = new TalentHubContext();
            _candidatoService = new BoCandidatoService(context);
        }

        #region Eventos do Formulário
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTituloEleitor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarCandidatos(true);
        }

        private void frmCadastroCandidato_Load(object sender, EventArgs e)
        {
            CarregarCandidatos(true);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCandidato(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCandidato(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _candidatoIdSelecionado = 0;
            Limparformulario();
            RecarregaGridAposCriarDado();
        }

        // Fix for the CS1503 error in the btnSalvar_Click method
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var candidato = new Candidato
            {
                Id = _candidatoIdSelecionado,
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,
                Bairro = txtBairro.Text,
                Cep = txtCep.Text,
                Cidade = txtCidade.Text,
                EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), cmbEstadoCivil.Text),
                CidadeNatal = txtCidadeNatal.Text,
                Nacionalidade = txtNacionalidade.Text,
                CpfCnpj = txtCpf.Text,
                Rg = txtRg.Text,
                UF = (Uf)Enum.Parse(typeof(Uf), cmbUF.Text),
                OrgaoEmissor = txtOrgaoEmissor.Text,
                NomeDaMae = txtNomeMae.Text,
                NumeroCTPS = txtNumeroCTPS.Text,
                SerieCTPS = txtSerieCTPS.Text,
                NumeroTituloEleitor = txtTituloEleitor.Text,
                ZonaTituloEleitor = txtZonaTituloEleitor.Text,
                SecaoTituloEleitor = txtSecaoTituloEleitor.Text,
                DataNascimento = dateDataNascimento.Value,
                Escolaridade = (Escolaridade)Enum.Parse(typeof(Escolaridade), cmbEscolaridade.Text),
                ExperienciaProfissional = (ExperienciaProfissional)Enum.Parse(typeof(ExperienciaProfissional), cmbExperiencia.Text),
                Habilidades = txtHabilidades.Text,
                Status = (StatusCandidato)Enum.Parse(typeof(StatusCandidato), cmbStatus.SelectedItem.ToString()),
                DataCadastro = DateTime.Now,
            };

            try
            {
                if (_candidatoIdSelecionado == 0)
                {
                    _candidatoService.AdicionarCandidato(candidato);
                    MessageBox.Show("Candidato cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _candidatoService.AtualizarCandidato(candidato);
                    MessageBox.Show("Candidato atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                RecarregaGridAposCriarDado();
            }
        }
        #endregion

        #region Métodos auxiliares
        /// <summary>
        /// Método para editar um candidato selecionado no DataGridView.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        private void EditarCandidato(int id)
        {
            var candidato = _candidatoService.ObterCandidatoPorId(id);
            try
            {
                if (candidato != null)
                {
                    _candidatoIdSelecionado = candidato.Id;
                    txtNome.Text = candidato.Nome;
                    txtEmail.Text = candidato.Email;
                    txtTelefone.Text = candidato.Telefone;
                    txtEndereco.Text = candidato.Endereco;
                    txtBairro.Text = candidato.Bairro;
                    txtCep.Text = candidato.Cep;
                    txtCidade.Text = candidato.Cidade;
                    cmbEstadoCivil.Text = candidato.EstadoCivil.ToString();
                    txtCidadeNatal.Text = candidato.CidadeNatal;
                    txtNacionalidade.Text = candidato.Nacionalidade;
                    txtCpf.Text = candidato.CpfCnpj;
                    txtRg.Text = candidato.Rg;
                    cmbUF.Text = candidato.UF.ToString();
                    txtOrgaoEmissor.Text = candidato.OrgaoEmissor;
                    txtNomeMae.Text = candidato.NomeDaMae;
                    txtNumeroCTPS.Text = candidato.NumeroCTPS;
                    txtSerieCTPS.Text = candidato.SerieCTPS;
                    txtTituloEleitor.Text = candidato.NumeroTituloEleitor;
                    txtZonaTituloEleitor.Text = candidato.ZonaTituloEleitor;
                    txtSecaoTituloEleitor.Text = candidato.SecaoTituloEleitor;
                    dateDataNascimento.Value = candidato.DataNascimento;
                    cmbEscolaridade.Text = candidato.Escolaridade.ToString();
                    cmbExperiencia.Text = candidato.ExperienciaProfissional.ToString();
                    txtHabilidades.Text = candidato.Habilidades;
                    cmbStatus.Text = candidato.Status.ToString();
                }
                else
                {
                    MessageBox.Show("Candidato não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar os dados do candidato: {ex.Message}");
            }
            finally
            {
                RecarregaGridAposCriarDado();
            }
        }

        /// <summary>
        /// Método para carregar os candidatos no DataGridView.
        /// </summary>
        private void CarregarCandidatos(bool apenasAtivos)
        {
            var candidatos = _candidatoService.ObterTodosCandidatos();

            if (apenasAtivos)
            {
                candidatos = candidatos.Where(c => c.Status == StatusCandidato.Ativo).ToList();
            }
                            
            dataGridView1.DataSource = candidatos.ToList();
        }

        /// <summary>
        /// Metodo para excluir um candidato selecionado.
        /// </summary>
        /// <param name="id"></param>
        private void ExcluirCandidato(int id)
        {
            _candidatoService.DeletarCandidato(id);
            MessageBox.Show("Candidato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarCandidatos(true);
        }

        /// <summary>
        /// Metodo para recarregar o DataGridView após a criação ou atualização de um candidato.
        /// </summary>
        private void RecarregaGridAposCriarDado()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear(); 
            CarregarCandidatos(true);
        }

        /// <summary>
        /// Método para limpar os campos do formulário.
        /// </summary>
        private void Limparformulario()
        {
            _candidatoIdSelecionado = 0;
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            cmbEstadoCivil.SelectedIndex = -1;
            txtCidadeNatal.Clear();
            txtNacionalidade.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            cmbUF.SelectedIndex = -1;
            txtOrgaoEmissor.Clear();
            txtNomeMae.Clear();
            txtNumeroCTPS.Clear();
            txtSerieCTPS.Clear();
            txtTituloEleitor.Clear();
            txtZonaTituloEleitor.Clear();
            txtSecaoTituloEleitor.Clear();
            dateDataNascimento.Value = DateTime.Now;
            cmbEscolaridade.SelectedIndex = -1;
            cmbExperiencia.SelectedIndex = -1;
            txtHabilidades.Clear();
            cmbStatus.SelectedIndex = -1;
        }
        #endregion
    }
}
