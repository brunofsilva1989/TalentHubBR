using Microsoft.Extensions.Logging;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoCandidatoService : ICandidatoService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        private readonly ILogger<BoCandidatoService> _logger;
        #endregion

        #region Construtores
        public BoCandidatoService(TalentHubContext context, ILogger<BoCandidatoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public BoCandidatoService(TalentHubContext context)
        {
            _context = context;            
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para adicionar um novo candidato.
        /// </summary>
        /// <param name="candidato"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AdicionarCandidato(Candidato candidato)
        {
            if (string.IsNullOrEmpty(candidato.Nome))
                throw new ArgumentException("Nome do candidato é obrigatório.");
            
            _context.Candidatos.Add(candidato);
            _context.SaveChanges();
        }

        /// <summary>
        /// Método para atualizar as informações de um candidato existente.
        /// </summary>
        /// <param name="candidato"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AtualizarCandidato(Candidato candidato)
        {            
            var candidatoExistente = _context.Candidatos.Find(candidato.Id);

            if (candidatoExistente == null)
                throw new ArgumentException("Candidato não encontrado.");

            candidatoExistente.Nome = candidato.Nome;
            candidatoExistente.Email = candidato.Email;
            candidatoExistente.Telefone = candidato.Telefone;
            candidatoExistente.Endereco = candidato.Endereco;
            candidatoExistente.Bairro = candidato.Bairro;
            candidatoExistente.Cep = candidato.Cep;
            candidatoExistente.Cidade = candidato.Cidade;
            candidatoExistente.UF = candidato.UF;
            candidatoExistente.EstadoCivil = candidato.EstadoCivil;
            candidatoExistente.CidadeNatal = candidato.CidadeNatal;
            candidatoExistente.Nacionalidade = candidato.Nacionalidade;
            candidatoExistente.CpfCnpj = candidato.CpfCnpj;
            candidatoExistente.Rg = candidato.Rg;
            candidatoExistente.OrgaoEmissor = candidato.OrgaoEmissor;
            candidatoExistente.NomeDaMae = candidato.NomeDaMae;
            candidatoExistente.NumeroCTPS = candidato.NumeroCTPS;
            candidatoExistente.SerieCTPS = candidato.SerieCTPS;
            candidatoExistente.NumeroTituloEleitor = candidato.NumeroTituloEleitor;
            candidatoExistente.ZonaTituloEleitor = candidato.ZonaTituloEleitor;
            candidatoExistente.SecaoTituloEleitor = candidato.SecaoTituloEleitor;
            candidatoExistente.DataNascimento = candidato.DataNascimento;
            candidatoExistente.Escolaridade = candidato.Escolaridade;
            candidatoExistente.ExperienciaProfissional = candidato.ExperienciaProfissional;
            candidatoExistente.Habilidades = candidato.Habilidades;
            candidatoExistente.Status = candidato.Status;
            
            _context.SaveChanges();
        }

        /// <summary>
        /// Método para deletar um candidato pelo ID.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentException"></exception>
        public void DeletarCandidato(int id)
        {
            var candidato = _context.Candidatos.Find(id);

            if (candidato == null)
                throw new ArgumentException("Candidato não encontrado.");
            
            _context.Candidatos.Remove(candidato);
            _context.SaveChanges();
        }

        /// <summary>
        /// Método para obter um candidato pelo ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Candidato ObterCandidatoPorId(int id)
        {
            var candidato = _context.Candidatos.Find(id);

            if (candidato == null)
                throw new ArgumentException("Candidato não encontrado.");
            
            _context.Entry(candidato).State = Microsoft.EntityFrameworkCore.EntityState.Detached;            
            return candidato;
        }

        /// <summary>
        /// Método para obter todos os candidatos cadastrados.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Candidato> ObterTodosCandidatos()
        {            
            return _context.Candidatos.ToList();            
        }
        #endregion
    }
}