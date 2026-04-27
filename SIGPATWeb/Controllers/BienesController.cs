using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class BienesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
