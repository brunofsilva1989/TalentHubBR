using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.BLL.Interfaces
{
    public interface IEmpresaService
    {
        void AdicionarEmpresa(string nome, string endereco, string telefone, string email);
        IEnumerable<string> ObterTodasEmpresas();
        string ObterEmpresaPorId(int id);
        void AtualizarEmpresa(int id, string nome, string endereco, string telefone, string email);
        void DeletarEmpresa(int id);
    }
}
