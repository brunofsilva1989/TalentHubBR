using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.BLL.Interfaces
{
    public interface IDocumentoService
    {
        void AdicionarDocumento(string nome, string tipo, byte[] conteudo);
        IEnumerable<string> ObterTodosDocumentos();
        string ObterDocumentoPorId(int id);
        void AtualizarDocumento(int id, string nome, string tipo, byte[] conteudo);
        void DeletarDocumento(int id);
    }
}
