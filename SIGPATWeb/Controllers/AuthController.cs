using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
