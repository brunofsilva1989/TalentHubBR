using System;
using System.Reflection.Metadata;
using TalentHub.Domain.Entities;
namespace TalentHub.BLL.Interfaces
{
    public interface IDocumentoService
    {
        void AdicionarDocumento(int candidatoId, string nome, string tipo, byte[] conteudo);
        IEnumerable<string> ObterTodosDocumentos();
        string ObterDocumentoPorId(int id);
        void AtualizarDocumento(int id, string nome, string tipo, byte[] conteudo);
        void DeletarDocumento(int id);
        IEnumerable<Documento> ObterDocumentosPorCandidato(int id, string filePath);
    }
}
