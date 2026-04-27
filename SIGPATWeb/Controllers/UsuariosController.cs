using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
