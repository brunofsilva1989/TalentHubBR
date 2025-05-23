using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Interfaces
{
    public interface ICandidatoService
    {        
        void AdicionarCandidato(Candidato candidato);        
        IEnumerable<Candidato> ObterTodosCandidatos();        
        Candidato ObterCandidatoPorId(int id);
        void AtualizarCandidato(Candidato candidato);
        void DeletarCandidato(int id);
    }
}
