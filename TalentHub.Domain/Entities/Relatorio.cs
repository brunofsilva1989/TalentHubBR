using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Relatorio
    {
        public int Id { get; set; }
        public string NomeRelatorio { get; set; }
        public override string ToString() => NomeRelatorio;
        public TipoRelatorio TipoRelatorio { get; set; } 
        public string CaminhoArquivo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataGeracao { get; set; } = DateTime.Now; 

        public int CandidatoId { get; set; } 
        public Candidato Candidato { get; set; }
        public string Conteudo { get; set; } 
        public int VagaId { get; set; } 
        public Vaga Vaga { get; set; }
        public Empresa Empresa { get; set; } 
        public int EmpresaId { get; set; } 
    }

    public enum TipoRelatorio
    {
        Candidato,
        Vaga,
        Feedback,
        Geral
    }
}
