using Microsoft.AspNetCore.Mvc;
using ProjetoPosDocker.Services.Interfaces;
using ProjetoPosDocker.ViewModel;

namespace ProjetoPosDocker.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            var listusuarios = _usuarioService.ObterUsuarios();

            var usuarioViewmodel = new UsuarioViewModel()
            {
                Usuarios = listusuarios
            };

            return View(usuarioViewmodel);
        }
    }
}
