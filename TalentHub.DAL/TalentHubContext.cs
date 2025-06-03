using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using TalentHub.Domain.Entities;

namespace TalentHub.DAL
{
    public class TalentHubContext : DbContext
    {

        #region Construtores
        public TalentHubContext(DbContextOptions<TalentHubContext> options) : base(options)
        {

        }
       
        public TalentHubContext() {}
        #endregion


        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }        
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);

            //Configuração da entidade Empresa
            modelBuilder.Entity<Empresa>(builder =>
            {
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Nome).IsRequired().HasMaxLength(150); // Define o nome como obrigatório e com tamanho máximo
                builder.Property(e => e.Contato).HasMaxLength(100); // Define o contato com tamanho máximo

                builder.HasMany(e => e.Vagas)
                    .WithOne(v => v.Empresa)
                    .HasForeignKey(v => v.EmpresaId); // Define a relação entre Empresa e Vaga

            });

            //Configuração da entidade Vaga
            modelBuilder.Entity<Vaga>(builder =>
            {
                builder.HasKey(v => v.Id);
                builder.Property(v => v.Descricao).IsRequired().HasMaxLength(500);
                builder.Property(v => v.EscopoVaga).HasMaxLength(300);
                builder.Property(v => v.Status).HasMaxLength(50);
                builder.Property(v => v.Cargo).IsRequired().HasMaxLength(100);
                builder.Property(v => v.Salario).HasColumnType("decimal(18,2)"); 
                builder.Property(v => v.DataAbertura).IsRequired();
                builder.Property(v => v.DataExpiracao).IsRequired();

                builder.HasMany(v => v.Feedbacks)
                    .WithOne(f => f.Vaga)
                    .HasForeignKey(f => f.VagaId);

                builder.HasMany(v => v.Relatorios)
                    .WithOne(r => r.Vaga)
                    .HasForeignKey(r => r.VagaId);
            });

            //Configuração da entidade Candidato
            modelBuilder.Entity<Candidato>(builder =>
            {
                builder.HasKey(c => c.Id); 
                builder.Property(c => c.Nome).IsRequired().HasMaxLength(150); 
                builder.Property(c => c.DataNascimento).IsRequired(); 
                builder.Property(c => c.Bairro).HasMaxLength(100); 
                builder.Property(c => c.Cep).HasMaxLength(10); 
                builder.Property(c => c.Cidade).HasMaxLength(100); 
                builder.Property(c => c.EstadoCivil).HasMaxLength(50);
                builder.Property(c => c.CidadeNatal).HasMaxLength(100); 
                builder.Property(c => c.Nacionalidade).HasMaxLength(100); 
                builder.Property(c => c.CpfCnpj).IsRequired().HasMaxLength(14); 
                builder.Property(c => c.Rg).IsRequired().HasMaxLength(20); 
                builder.Property(c => c.OrgaoEmissor).HasMaxLength(50); 
                builder.Property(c => c.NomeDaMae).HasMaxLength(150); 
                builder.Property(c => c.NumeroCTPS).HasMaxLength(20); 
                builder.Property(c => c.SerieCTPS).HasMaxLength(10); 
                builder.Property(c => c.NumeroTituloEleitor).HasMaxLength(20); 
                builder.Property(c => c.ZonaTituloEleitor).HasMaxLength(10); 
                builder.Property(c => c.SecaoTituloEleitor).HasMaxLength(10); 
                builder.Property(c => c.Email).HasMaxLength(100); 
                builder.Property(c => c.Telefone).HasMaxLength(20); 
                builder.Property(c => c.Endereco).HasMaxLength(250); 
                builder.Property(c => c.Escolaridade).HasMaxLength(100); 
                builder.Property(c => c.ExperienciaProfissional).HasMaxLength(500); 
                builder.Property(c => c.Habilidades).HasMaxLength(500); 
                builder.Property(c => c.Status).HasConversion<string>();

                builder.HasMany(c => c.Documentos)
                    .WithOne(d => d.Candidato)
                    .HasForeignKey(d => d.CandidatoId);

                builder.HasMany(c => c.Relatorios)
                    .WithOne(r => r.Candidato)
                    .HasForeignKey(r => r.CandidatoId);

                builder.HasMany(c => c.Feedbacks)
                    .WithOne(f => f.Candidato)
                    .HasForeignKey(f => f.CandidatoId);
            });
            
            //Configuração da entidade Documento
            modelBuilder.Entity<Documento>(builder =>
            {
                builder.HasKey(d => d.Id);
                builder.Property(d => d.Nome).IsRequired().HasMaxLength(150); 
                builder.Property(d => d.Tipo).HasMaxLength(50); 
                builder.Property(d => d.Conteudo).IsRequired(); 
            });

            //Configuração da entidade Relatorio
            modelBuilder.Entity<Relatorio>(builder =>
            {
                builder.HasKey(r => r.Id);
                builder.Property(r => r.NomeRelatorio).IsRequired().HasMaxLength(150); 
                builder.Property(r => r.TipoRelatorio).HasMaxLength(50); 
                builder.Property(r => r.Descricao).HasMaxLength(500); 
                builder.Property(r => r.Conteudo).IsRequired(); 

                builder.HasOne(r => r.Candidato)
                    .WithMany(c => c.Relatorios)
                    .HasForeignKey(r => r.CandidatoId); 

                builder.HasOne(r => r.Vaga)
                    .WithMany(v => v.Relatorios)
                    .HasForeignKey(r => r.VagaId); 
            });

            //Configuração da entidade Feedback
            modelBuilder.Entity<Feedback>(builder =>
            {
                builder.HasKey(f => f.Id);
                builder.Property(f => f.Comentario).IsRequired().HasMaxLength(500); 
                builder.Property(f => f.DataFeedback).IsRequired(); 
                builder.HasOne(f => f.Candidato)
                    .WithMany(c => c.Feedbacks)
                    .HasForeignKey(f => f.CandidatoId); 
                builder.HasOne(f => f.Vaga)
                    .WithMany(v => v.Feedbacks)
                    .HasForeignKey(f => f.VagaId); 
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Busca do appsettings.json do projeto UI
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) 
                    .AddJsonFile("appsettings.json") 
                    .Build();

                string connectionString = configuration.GetConnectionString("MinhaConexao");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
        
}
