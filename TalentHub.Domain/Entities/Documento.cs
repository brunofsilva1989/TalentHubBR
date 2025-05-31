using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Documento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString() => Nome;
        public string Tipo { get; set; } // Ex: PDF, DOCX, etc.
        public byte[] Conteudo { get; set; } // Conteúdo do documento em bytes
        public DateTime DataUpload { get; set; } = DateTime.Now;
        public int CandidatoId { get; set; } // Chave estrangeira para o candidato
        public Candidato Candidato { get; set; } // Navegação para o candidato
    }
}
