using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Interfaces
{
    public interface IVagaService
    {
        void AdicionarVaga(Vaga vaga);
        IEnumerable<Vaga> ObterTodasVagas();
        Vaga ObterVagaPorId(int id);
        void AtualizarVaga(Vaga vaga);
        void DeletarVaga(int id);
    }
}
