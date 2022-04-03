using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
