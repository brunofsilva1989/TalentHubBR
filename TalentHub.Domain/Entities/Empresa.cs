using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public ICollection<Vaga> Vagas { get; set; } // Changed from private to public
    }
}
