using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class IAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
