using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHub.BLL.Interfaces;
using TalentHub.BLL.Services;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmBancoTalentos : Form
    {
        private readonly ICandidatoService _candidatoService;
        private Form _formOrigem;

        public frmBancoTalentos(Form formOrigem)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            _formOrigem = formOrigem;
            var context = new TalentHub.DAL.TalentHubContext();
            _candidatoService = new BoCandidatoService(context);
        }

        private void btnReativarCandidato_Click(object sender, EventArgs e)
        {
            var candidato = dgvTalentos.CurrentRow?.DataBoundItem as Candidato;

            try
            {
                if (candidato != null)
                {
                    candidato.Status = StatusCandidato.Ativo;
                    _candidatoService.AtualizarCandidato(candidato);

                    MessageBox.Show("Candidato reativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarBancoDeTalentos();
                }
                MessageBox.Show($"Candidato {candidato} reativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reativar o candidato: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CarregarBancoDeTalentos()
        {
            var talentos = _candidatoService.ObterTodosCandidatos()
                .Where(c => c.Status == StatusCandidato.BancoDeTalentos)
                .ToList();

            dgvTalentos.DataSource = talentos;
        }

        private void dgvTalentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarBancoDeTalentos();
        }

        private void frmBancoTalentos_Load(object sender, EventArgs e)
        {
            CarregarBancoDeTalentos();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            _formOrigem.Show(); // Esconde o formulário de origem
            this.Close(); // Fecha o formulário atual
        }
    }
}
