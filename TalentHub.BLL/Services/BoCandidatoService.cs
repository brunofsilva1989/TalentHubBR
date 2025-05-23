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
    public class BoCandidatoService : ICandidatoService
    {
        private readonly TalentHubContext _context;

        public BoCandidatoService(TalentHubContext context)
        {
            _context = context;
        }

        public void AdicionarCandidato(Candidato candidato)
        {
            if (string.IsNullOrEmpty(candidato.Nome))
                throw new ArgumentException("Nome do candidato é obrigatório.");

            _context.Candidatos.Add(candidato);
            _context.SaveChanges();
        }

        public void AtualizarCandidato(Candidato candidato)
        {
            _context.Candidatos.Update(candidato);
        }

        public void DeletarCandidato(int id)
        {
            var candidato = _context.Candidatos.Find(id);

            if (candidato != null)
            {
                _context.Candidatos.Remove(candidato);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Candidato não encontrado.");
            }
        }

        public Candidato ObterCandidatoPorId(int id)
        {
            var candidato = _context.Candidatos.Find(id);

            if (candidato != null)
            {
                _context.Entry(candidato).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                return candidato;
            }
            else
            {
                throw new ArgumentException("Candidato não encontrado.");
            }

        }

        public IEnumerable<Candidato> ObterTodosCandidatos()
        {
            return _context.Candidatos.ToList();
        }
    }
}
