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
        public string NomeRelatorio { get; set; } // Nome do relatório
        public string TipoRelatorio { get; set; } // Tipo de relatório (ex: PDF, Excel, etc.)
        public string CaminhoArquivo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataGeracao { get; set; } = DateTime.Now; // Data de geração do relatório

        public int CandidatoId { get; set; } // Chave estrangeira para o candidato
        public Candidato Candidato { get; set; }
        public string Conteudo { get; set; } // Conteúdo do relatório em formato apropriado (ex: JSON, XML, etc.)
        public int VagaId { get; set; } // Chave estrangeira para a vaga relacionada
        public Vaga Vaga { get; set; } // Navegação para a vaga relacionadaa
    }
}
