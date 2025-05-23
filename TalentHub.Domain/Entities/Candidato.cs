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
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }        
        public string EstadoCivil { get; set; }
        public string CidadeNatal { get; set; }
        public string Nacionalidade { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public string NomeDaMae { get; set; }
        public string NumeroCTPS { get; set; }
        public string SerieCTPS { get; set; }
        public string NumeroTituloEleitor { get; set; }
        public string ZonaTituloEleitor { get; set; }
        public string SecaoTituloEleitor { get; set; }
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