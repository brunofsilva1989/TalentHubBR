using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;

namespace TalentHub.BLL.Services
{
    public class BoEmpresaService : IEmpresaService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoEmpresaService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void AdicionarEmpresa(string nome, string endereco, string telefone, string email)
        {
            throw new NotImplementedException();
        }

        public void AtualizarEmpresa(int id, string nome, string endereco, string telefone, string email)
        {
            throw new NotImplementedException();
        }

        public void DeletarEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public string ObterEmpresaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ObterTodasEmpresas()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
