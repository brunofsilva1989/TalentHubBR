using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoVagaService : IVagaService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoVagaService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void AdicionarVaga(Vaga vaga)
        {
            throw new NotImplementedException();
        }


        public void AtualizarVaga(Vaga vaga)
        {
            throw new NotImplementedException();
        }

        public void DeletarVaga(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vaga> ObterTodasVagas()
        {
            throw new NotImplementedException();
        }

        public Vaga ObterVagaPorId(int id)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
