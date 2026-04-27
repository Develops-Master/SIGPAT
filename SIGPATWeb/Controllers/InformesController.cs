using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class InformesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
