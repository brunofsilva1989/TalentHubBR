using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Escolaridade { get; set; }
        public string ExperienciaProfissional { get; set; }
        public string Habilidades { get; set; }
        public StatusCandidato Status { get; set; } 
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<Documento> Documentos { get; set; } = new List<Documento>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }

    public enum StatusCandidato
    {
        Aguardando,
        Entrevista,
        Contratado,
        Rejeitado
    }
}