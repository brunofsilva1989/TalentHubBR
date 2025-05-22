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
        public int EmpresaId { get; set; } // Chave estrangeira para a empresa
        public Empresa Empresa { get; set; }
        public string Descricao { get; set; }
        public string Escopo { get; set; }
        public string Status { get; set; }        
        public DateTime DataAbertura { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }
}
