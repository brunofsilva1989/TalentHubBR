using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;

namespace TalentHub.BLL.Services
{
    public class BoRelatorioService : IRelatorioService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoRelatorioService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void GerarRelatorioCandidatos(string filePath)
        {
            throw new NotImplementedException();
        }

        public void GerarRelatorioEmpresas(string filePath)
        {
            throw new NotImplementedException();
        }

        public void GerarRelatorioFeedbacks(string filePath)
        {
            throw new NotImplementedException();
        }

        public void GerarRelatorioVagas(string filePath)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
