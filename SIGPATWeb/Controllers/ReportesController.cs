using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
