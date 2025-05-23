using System.Data.Common;
using TalentHub.BLL.Services;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmCadastroCandidato : Form
    {
        private readonly BoCandidatoService _candidatoService;

        public frmCadastroCandidato()
        {
            InitializeComponent();

            var context = new TalentHubContext();
            _candidatoService = new BoCandidatoService(context);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var candidato = new Candidato
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                DataNascimento = dateDataNascimento.Value,
                Endereco = txtEndereco.Text,
                Cep = txtCep.Text,
                Bairro = txtBairro.Text,
                CidadeNatal = txtCidadeNatal.Text,
                Nacionalidade = txtNacionalidade.Text,
                CpfCnpj = txtCpf.Text,
                Rg = txtRg.Text,
                OrgaoEmissor = txtOrgaoEmissor.Text,
                NomeDaMae = txtNomeMae.Text,
                NumeroCTPS = txtNumeroCTPS.Text,
                SerieCTPS = txtSerieCTPS.Text,
                NumeroTituloEleitor = txtTituloEleitor.Text,
                ZonaTituloEleitor = txtZonaTituloEleitor.Text,
                SecaoTituloEleitor = txtSecaoTituloEleitor.Text,
                Habilidades = txtHabilidades.Text,
                Escolaridade = txtEscolaridade.Text,
                ExperienciaProfissional = txtExperienciaProfissional.Text,
                Cidade = txtCidade.Text,
                EstadoCivil = txtEstado.Text
            };

            _candidatoService.AdicionarCandidato(candidato);
            MessageBox.Show("Candidato cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTituloEleitor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarCandidatos()
        {
            var candidatos = _candidatoService.ObterTodosCandidatos();
            dataGridView1.DataSource = candidatos.ToList();
        }

        private void frmCadastroCandidato_Load(object sender, EventArgs e)
        {
            CarregarCandidatos();
        }
    }
}
