using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoDocumentoService : IDocumentoService
    {
        private readonly TalentHubContext _context;
        public BoDocumentoService(TalentHubContext context)
        {
            _context = context;
        }

        public void AdicionarDocumento(int candidatoId, string nome, string tipo, byte[] conteudo)
        {
            if (string.IsNullOrEmpty(tipo) || conteudo == null || conteudo.Length == 0)
            {
                throw new ArgumentException("Nome, tipo e conteúdo do documento são obrigatórios.");
            }

            var documento = new Documento
            {
                Nome = nome,
                Tipo = tipo,
                Conteudo = conteudo,
                CandidatoId = candidatoId,
            };

            _context.Documentos.Add(documento);
            _context.SaveChanges();

        }

        public void AtualizarDocumento(int id, string nome, string tipo, byte[] conteudo)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(tipo) || conteudo == null || conteudo.Length == 0)
            {
                throw new ArgumentException("Nome, tipo e conteúdo do documento são obrigatórios.");
            }
            var documento = _context.Documentos.Find(id);
            if (documento == null)
            {
                throw new KeyNotFoundException("Documento não encontrado.");
            }
            documento.Nome = nome;
            documento.Tipo = tipo;
            documento.Conteudo = conteudo;
            _context.Documentos.Update(documento);
            _context.SaveChanges();

        }

        public void DeletarDocumento(int id)
        {
            var documento = _context.Documentos.Find(id);
            if (documento == null)
            {
                throw new KeyNotFoundException("Documento não encontrado.");
            }
            _context.Documentos.Remove(documento);
            _context.SaveChanges();
        }

        public string ObterDocumentoPorId(int id)
        {
            var documento = _context.Documentos.Find(id);
            if (documento == null)
            {
                throw new KeyNotFoundException("Documento não encontrado.");
            }

            return Convert.ToBase64String(documento.Conteudo);
        }

        public IEnumerable<string> ObterTodosDocumentos()
        {
            return _context.Documentos.Select(d => $"{d.Id} - {d.Nome} ({d.Tipo})").ToList();
        }

        public IEnumerable<Documento> ObterDocumentosPorCandidato(int candidatoId)
        {
            
            if (candidatoId <= 0)
            {
                throw new ArgumentException("ID do candidato deve ser maior que zero.");
            }
            else
            {
                return _context.Documentos
                .Where(d => d.CandidatoId == candidatoId)
                .ToList();

            }
        }

        public IEnumerable<Documento> ObterDocumentosPorCandidato(int id, string filePath)
        {
            var documentos = _context.Documentos
                .Where(d => d.CandidatoId == id)
                .ToList();

            if (documentos == null || !documentos.Any())
                {
                throw new KeyNotFoundException("Nenhum documento encontrado para o candidato especificado.");
            }

            foreach (var documento in documentos)
            {
                var fileName = $"{filePath}/{documento.Nome}.{documento.Tipo}";
                System.IO.File.WriteAllBytes(fileName, documento.Conteudo);
            }

            return documentos;
        }
    }
}
