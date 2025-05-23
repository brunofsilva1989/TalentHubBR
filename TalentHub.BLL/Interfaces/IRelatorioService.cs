using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.BLL.Interfaces
{
    public interface IRelatorioService
    {
        void GerarRelatorioCandidatos(string filePath);
        void GerarRelatorioVagas(string filePath);
        void GerarRelatorioFeedbacks(string filePath);
        void GerarRelatorioEmpresas(string filePath);
    }
}
