﻿namespace TalentHub.Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
        public string ?Contato { get; set; }
        public string ?Email { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new List<Vaga>();
    }
}
