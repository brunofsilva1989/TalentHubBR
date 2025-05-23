using TalentHub.BLL.Interfaces;
using TalentHub.DAL;

namespace TalentHub.BLL.Services
{
    public class BoFeedbackService : IFeedbackService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoFeedbackService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void AdicionarFeedback(string feedback)
        {
            throw new NotImplementedException();
        }

        public void AtualizarFeedback(int id, string feedback)
        {
            throw new NotImplementedException();
        }

        public void DeletarFeedback(int id)
        {
            throw new NotImplementedException();
        }

        public string ObterFeedbackPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ObterTodosFeedbacks()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
