using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoEmpresaService : IEmpresaService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoEmpresaService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void AdicionarEmpresa(Empresa empresa)
        {
            var empresaExistente = _context.Empresas.FirstOrDefault(e => e.Nome == empresa.Nome);

            if (empresaExistente != null)
                throw new ArgumentException("Empresa já cadastrada.");
            
            var novaEmpresa = new Empresa
            {
                Nome = empresa.Nome,
                Contato = empresa.Contato,
                Email = empresa.Email
            };

            _context.Empresas.Add(novaEmpresa);
            _context.SaveChanges();
        }

        public void AtualizarEmpresa(Empresa empresa)
        {
            var empresaExistente = _context.Empresas.Find(empresa.Id);

            if (empresaExistente == null)
                throw new ArgumentException("Empresa não encontrada.");

            empresaExistente.Nome = empresa.Nome;
            empresaExistente.Contato = empresa.Contato;
            empresaExistente.Email = empresa.Email;
            
            _context.SaveChanges();
        }

        public void DeletarEmpresa(int id)
        {
            var empresa = _context.Empresas.Find(id);

            if (empresa == null)
                throw new ArgumentException("Empresa não encontrada.");

            _context.Empresas.Remove(empresa);
            _context.SaveChanges();
        }

        public Empresa ObterEmpresaPorId(int id)
        {
            var empresa = _context.Empresas.Find(id);

            if (empresa == null)
                throw new ArgumentException("Empresa não encontrada.");

            return empresa;
        }

        public IEnumerable<Empresa> ObterTodasEmpresas()
        {
            return _context.Empresas.ToList();
        }
        #endregion
    }
}
