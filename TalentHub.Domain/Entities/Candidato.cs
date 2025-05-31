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
        public override string ToString() => Nome;
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public Uf UF { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
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
        public Escolaridade Escolaridade { get; set; }
        public ExperienciaProfissional ExperienciaProfissional { get; set; }
        public string Habilidades { get; set; }
        public StatusCandidato Status { get; set; } 
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<Documento> Documentos { get; set; } = new List<Documento>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }

    public enum StatusCandidato
    {        
        Ativo,
        BancoDeTalentos,
        Rejeitado        
    }

    public enum Escolaridade
    {
        FundamentalIncompleto,
        FundamentalCompleto,
        MedioIncompleto,
        MedioCompleto,
        SuperiorIncompleto,
        SuperiorCompleto,
        PosGraduacaoIncompleto,
        PosGraduacaoCompleto
    }

    public enum ExperienciaProfissional
    {
        Nenhuma,
        MenosDeUmAno,
        UmAno,
        DoisAnos,
        TresAnosOuMais
    }

    public enum Uf
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO
    }

    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo,
        Separado
    }
}