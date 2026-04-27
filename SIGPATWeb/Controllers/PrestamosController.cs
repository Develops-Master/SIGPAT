using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
