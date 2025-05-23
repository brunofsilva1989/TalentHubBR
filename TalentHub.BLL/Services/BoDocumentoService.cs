using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;

namespace TalentHub.BLL.Services
{
    public class BoDocumentoService : IDocumentoService
    {
        private readonly TalentHubContext _context;
        public BoDocumentoService(TalentHubContext context)
        {
            _context = context;
        }

        public void AdicionarDocumento(string nome, string tipo, byte[] conteudo)
        {
            throw new NotImplementedException();
        }

        public void AtualizarDocumento(int id, string nome, string tipo, byte[] conteudo)
        {
            throw new NotImplementedException();
        }

        public void DeletarDocumento(int id)
        {
            throw new NotImplementedException();
        }

        public string ObterDocumentoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ObterTodosDocumentos()
        {
            throw new NotImplementedException();
        }
    }
}
