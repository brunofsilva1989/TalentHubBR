using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Interfaces
{
    public interface IEmpresaService
    {
        void AdicionarEmpresa(Empresa empresa);
        IEnumerable<Empresa> ObterTodasEmpresas();
        Empresa ObterEmpresaPorId(int id);
        void AtualizarEmpresa(Empresa empresa);
        void DeletarEmpresa(int id);
    }
}
