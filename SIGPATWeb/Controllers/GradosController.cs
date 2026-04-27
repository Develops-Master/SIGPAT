using Microsoft.AspNetCore.Mvc;

namespace SIGPATWeb.Controllers
{
    public class GradosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
