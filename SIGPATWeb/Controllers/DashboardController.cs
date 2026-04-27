using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
