using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
