using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.BLL.Interfaces
{
    public interface IFeedbackService
    {
        void AdicionarFeedback(string feedback);
        IEnumerable<string> ObterTodosFeedbacks();
        string ObterFeedbackPorId(int id);
        void AtualizarFeedback(int id, string feedback);
        void DeletarFeedback(int id);
    }
}
