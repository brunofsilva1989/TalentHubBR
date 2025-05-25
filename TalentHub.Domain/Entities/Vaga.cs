using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Vaga
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public string Descricao { get; set; }
        public string EscopoVaga { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public StatusVaga Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataExpiracao { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }

    public enum StatusVaga
    {
        Aberta,
        Fechada,
        EmAnalise,
        Cancelada
    }
}
