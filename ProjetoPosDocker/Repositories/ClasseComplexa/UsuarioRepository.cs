using ProjetoPosDocker.Data;
using ProjetoPosDocker.Models;
using ProjetoPosDocker.Repositories.Interfaces;

namespace ProjetoPosDocker.Repositories.ClasseComplexa
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository() { }

        public ICollection<Usuario> ObterTodosUsuarios()
        {
            return UsuarioData.GetListUsuarios();
        }
    }
}
