using Microsoft.EntityFrameworkCore;
using TalentHub.Domain.Entities;

namespace TalentHub.DAL
{
    public class TalentHubContext : DbContext
    {
        public TalentHubContext(DbContextOptions<TalentHubContext> options) : base(options)
        {

        }

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
                builder.Property(v => v.Escopo).HasMaxLength(300);
                builder.Property(v => v.Status).HasMaxLength(50);

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
                builder.HasKey(c => c.Id); // Define a chave primária
                builder.Property(c => c.Nome).IsRequired().HasMaxLength(150); // Define o nome como obrigatório e com tamanho máximo
                builder.Property(c => c.Email).HasMaxLength(100); // Define o email com tamanho máximo
                builder.Property(c => c.Telefone).HasMaxLength(20); // Define o telefone com tamanho máximo
                builder.Property(c => c.Endereco).HasMaxLength(250); // Define o endereço com tamanho máximo
                builder.Property(c => c.Escolaridade).HasMaxLength(100); // Define a escolaridade com tamanho máximo
                builder.Property(c => c.ExperienciaProfissional).HasMaxLength(500); // Define a experiência profissional com tamanho máximo
                builder.Property(c => c.Habilidades).HasMaxLength(500); // Define as habilidades com tamanho máximo
                builder.Property(c => c.Status).HasConversion<string>();

                builder.HasMany(c => c.Documentos)
                    .WithOne(d => d.Candidato)
                    .HasForeignKey(d => d.CandidatoId);

                builder.HasMany(c => c.Relatorios)
                    .WithOne(r => r.Candidato)
                    .HasForeignKey(r => r.CandidatoId);
            });

            //Configuração da entidade Documento
            modelBuilder.Entity<Documento>(builder =>
            {
                builder.HasKey(d => d.Id);
                builder.Property(d => d.Nome).IsRequired().HasMaxLength(150); // Define o nome como obrigatório e com tamanho máximo
                builder.Property(d => d.Tipo).HasMaxLength(50); // Define o tipo com tamanho máximo
                builder.Property(d => d.Conteudo).IsRequired(); // Define o conteúdo como obrigatório
            });

            //Configuração da entidade Relatorio
            modelBuilder.Entity<Relatorio>(builder =>
            {
                builder.HasKey(r => r.Id);
                builder.Property(r => r.NomeRelatorio).IsRequired().HasMaxLength(150); // Define o nome do relatório como obrigatório e com tamanho máximo
                builder.Property(r => r.TipoRelatorio).HasMaxLength(50); // Define o tipo de relatório com tamanho máximo
                builder.Property(r => r.Descricao).HasMaxLength(500); // Define a descrição com tamanho máximo
                builder.Property(r => r.Conteudo).IsRequired(); // Define o conteúdo como obrigatório

                builder.HasOne(r => r.Candidato)
                    .WithMany(c => c.Relatorios)
                    .HasForeignKey(r => r.CandidatoId); // Define a relação entre Relatório e Candidato

                builder.HasOne(r => r.Vaga)
                    .WithMany(v => v.Relatorios)
                    .HasForeignKey(r => r.VagaId); // Define a relação entre Relatório e Vaga
            });

            //Configuração da entidade Feedback
            modelBuilder.Entity<Feedback>(builder =>
            {
                builder.HasKey(f => f.Id);
                builder.Property(f => f.Comentario).IsRequired().HasMaxLength(500); // Define o comentário como obrigatório e com tamanho máximo
                builder.Property(f => f.DataFeedback).IsRequired(); // Define a data do feedback como obrigatória
                builder.HasOne(f => f.Candidato)
                    .WithMany(c => c.Feedbacks)
                    .HasForeignKey(f => f.CandidatoId); // Define a relação entre Feedback e Candidato
                builder.HasOne(f => f.Vaga)
                    .WithMany(v => v.Feedbacks)
                    .HasForeignKey(f => f.VagaId); // Define a relação entre Feedback e Vaga
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DEVBRUNO;Database=TalentHubDB;User Id=sa;Password=Bru@1989;TrustServerCertificate=True;");
        }
    }
        
}
