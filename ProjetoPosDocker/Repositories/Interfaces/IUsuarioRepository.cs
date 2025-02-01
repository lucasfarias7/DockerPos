using ProjetoPosDocker.Models;

namespace ProjetoPosDocker.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        ICollection<Usuario> ObterTodosUsuarios();
    }
}
