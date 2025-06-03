using TalentHubBR.UI;
using TalentHubBR.UI.TelasSistema;
using Microsoft.Extensions.Configuration;

namespace TalentHubBR
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            // 🔧 Configuração
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}