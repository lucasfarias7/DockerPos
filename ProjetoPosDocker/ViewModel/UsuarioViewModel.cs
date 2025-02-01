using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoPosDocker.Models;

namespace ProjetoPosDocker.ViewModel
{
    public class UsuarioViewModel
    {       
        public UsuarioViewModel()
        {            
        }

        public ICollection<Usuario> Usuarios { get; set; } =  new List<Usuario>();        
    }
}
