using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentHub.DAL
{
    public class TalentHubContextFactory : IDesignTimeDbContextFactory<TalentHubContext>
    {
        public TalentHubContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TalentHubContext>();

            optionsBuilder.UseSqlServer("Server=DEVBRUNO;Database=TalentHubDB;User Id=sa;Password=Bru@1989;TrustServerCertificate=True;"); // Substitua pela sua string de conexão

            return new TalentHubContext(optionsBuilder.Options);
        }

    }
}
