using ProjetoPosDocker.Repositories.ClasseComplexa;
using ProjetoPosDocker.Repositories.Interfaces;
using ProjetoPosDocker.Services.ClassesComplexas;
using ProjetoPosDocker.Services.Interfaces;

namespace ProjetoPosDocker.Register
{
    public static class InjecaoDependencia
    {
        public static void RegistrarInjecaoDepencia(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioService, UsuarioService>();
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
