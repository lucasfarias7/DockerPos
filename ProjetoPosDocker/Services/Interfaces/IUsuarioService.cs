using ProjetoPosDocker.Models;

namespace ProjetoPosDocker.Services.Interfaces
{
    public interface IUsuarioService
    {
        ICollection<Usuario> ObterUsuarios();
    }
}
