using Microsoft.Extensions.Logging;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoVagaService : IVagaService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        private readonly ILogger<BoVagaService> _logger;
        #endregion

        #region Construtores
        public BoVagaService(TalentHubContext context, ILogger<BoVagaService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public BoVagaService(TalentHubContext context)
        {
            _context = context;            
        }
        #endregion

        #region Métodos
        public void AdicionarVaga(Vaga vaga)
        {
            var vagaExistente = _context.Vagas.FirstOrDefault(v => v.Descricao == vaga.Descricao && v.EmpresaId == vaga.EmpresaId);
            
            if (vagaExistente == null)
            {                
                _context.Vagas.Add(vaga);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning($"Vaga com descrição '{vaga.Descricao}' já existe para a empresa com ID {vaga.EmpresaId}.");
                throw new InvalidOperationException($"Vaga com descrição '{vaga.Descricao}' já existe para a empresa com ID {vaga.EmpresaId}.");
            }
        }


        public void AtualizarVaga(Vaga vaga)
        {
            var vagaExistente = _context.Vagas.Find(vaga.Id);

            if (vagaExistente == null)
            {                
                throw new KeyNotFoundException($"Vaga com ID {vaga.Id} não encontrada.");
            }

            vagaExistente.Descricao = vaga.Descricao;
            vagaExistente.EscopoVaga = vaga.EscopoVaga;
            vagaExistente.Status = vaga.Status;
            vagaExistente.EmpresaId = vaga.EmpresaId;
            vagaExistente.DataAbertura = vaga.DataAbertura;
            vagaExistente.DataExpiracao = vaga.DataExpiracao;
            vagaExistente.Cargo = vaga.Cargo;
            vagaExistente.Salario = vaga.Salario;
            
            _context.Vagas.Update(vagaExistente);
            _context.SaveChanges();

        }

        public void DeletarVaga(int id)
        {
            var vaga = _context.Vagas.Find(id);

            if (vaga == null)
            {                
                throw new KeyNotFoundException($"Vaga com ID {id} não encontrada.");
            }

            _context.Vagas.Remove(vaga);
            _context.SaveChanges();
        }

        public IEnumerable<Vaga> ObterTodasVagas()
        {
            return _context.Vagas.ToList();
        }

        public Vaga ObterVagaPorId(int id)
        {
           var vaga = _context.Vagas.FirstOrDefault(v => v.Id == id);

            if (vaga == null)
            {                
                throw new KeyNotFoundException($"Vaga com ID {id} não encontrada.");
            }
            
            return vaga;
        }
        #endregion
    }
}
