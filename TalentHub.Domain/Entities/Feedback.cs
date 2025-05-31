using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public override string ToString() => $"{Candidato?.Nome} - {Comentario}"; // Exibição personalizada do feedback
        public string Comentario { get; set; } // Comentário do feedback
        public DateTime DataFeedback { get; set; } = DateTime.Now; // Data do feedback
        public int CandidatoId { get; set; } // Chave estrangeira para o candidato
        public Candidato Candidato { get; set; } // Navegação para o candidato
        public int VagaId { get; set; } // Chave estrangeira para a vaga relacionada
        public Vaga Vaga { get; set; } // Navegação para a vaga relacionada

        ICollection<Vaga> vagas { get; set; } = new List<Vaga>(); // Lista de vagas relacionadas ao feedback
    }
}
