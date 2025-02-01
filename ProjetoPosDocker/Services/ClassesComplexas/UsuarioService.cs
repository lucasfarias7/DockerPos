using ProjetoPosDocker.Models;
using ProjetoPosDocker.Repositories.Interfaces;
using ProjetoPosDocker.Services.Interfaces;

namespace ProjetoPosDocker.Services.ClassesComplexas
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }


        public ICollection<Usuario> ObterUsuarios()
        {
            return _usuarioRepository.ObterTodosUsuarios();
        }
    }
}
