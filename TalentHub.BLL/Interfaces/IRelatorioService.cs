using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Interfaces
{
    public interface IRelatorioService
    {
        void GerarRelatorioCandidatosGeral(string filePath);
        void GerarRelatorioCandidatoIndividual(int id, string filePath);
        void GerarRelatorioVagasGeral(string filePath);
        void GerarRelatorioVagaIndividual(int id, string filePath);
        void GerarRelatorioFeedbacksGeral(string filePath);
        void GerarRelatorioFeedbackIndividual(int idFeedback, int idCandidato, string filePath);
        void GerarRelatorioEmpresasGeral(string filePath);
        void GerarRelatorioEmpresasIndividual(int id, string filePath);
    }
}
