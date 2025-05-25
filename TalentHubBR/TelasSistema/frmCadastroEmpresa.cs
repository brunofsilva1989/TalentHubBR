using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalentHub.BLL.Services;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmCadastroEmpresa : Form
    {
        #region Propriedades Privadas
        private readonly BoEmpresaService _empresaService;
        private int _empresaIdSelecionada = 0;
        #endregion

        public frmCadastroEmpresa()
        {
            InitializeComponent();

            var context = new TalentHubContext();
            _empresaService = new BoEmpresaService(context);
        }

        #region Eventos do Formulário
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa
            {
                Id = _empresaIdSelecionada,
                Nome = txtNomeEmpresa.Text,
                Contato = txtContatoEmpresa.Text,
                Email = txtEmail.Text
            };

            try
            {
                if (_empresaIdSelecionada == 0)
                {
                    _empresaService.AdicionarEmpresa(empresa);
                    MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _empresaService.AtualizarEmpresa(empresa);
                    MessageBox.Show("Empresa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a empresa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RecarregarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpresa(Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value));
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            CarregarEmpresas();
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarEmpresas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirEmpresa(Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value));
        }
        #endregion

        #region Métodos Privados
        private void EditarEmpresa(int empresaId)
        {
            var empresaSelecionada = _empresaService.ObterEmpresaPorId(empresaId);
            try
            {
                if (empresaSelecionada != null)
                {
                    _empresaIdSelecionada = empresaSelecionada.Id; 
                    txtNomeEmpresa.Text = empresaSelecionada.Nome;
                    txtContatoEmpresa.Text = empresaSelecionada.Contato;
                    txtEmail.Text = empresaSelecionada.Email;
                }
                else
                {
                    MessageBox.Show("Selecione uma empresa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar a empresa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                RecarregarGrid();
            }
        }

        private void LimparCampos()
        {
            txtNomeEmpresa.Clear();
            txtContatoEmpresa.Clear();
            txtEmail.Clear();
            _empresaIdSelecionada = 0;
        }

        private void CarregarEmpresas()
        {
            var empresas = _empresaService.ObterTodasEmpresas();
            dgvEmpresas.DataSource = empresas.ToList();
        }

        private void RecarregarGrid()
        {
            dgvEmpresas.DataSource = null;
            dgvEmpresas.ClearSelection();
            CarregarEmpresas();            
        }

        private void ExcluirEmpresa(int id)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecione uma empresa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _empresaService.DeletarEmpresa(id);
                MessageBox.Show("Empresa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a empresa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RecarregarGrid();
            }
        }
        #endregion        
    }
}
