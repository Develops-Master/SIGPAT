using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class AlertasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
