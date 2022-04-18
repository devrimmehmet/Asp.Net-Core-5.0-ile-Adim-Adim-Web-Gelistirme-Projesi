using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {

        // [Authorize(Roles = "Admin")]
        //public IActionResult Index()
        //{


        //    return View();
        //}

        public readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.z = values.Name;
            ViewBag.z1 = values.Name+" "+values.Surname;
            ViewBag.z2 = values.ImageUrl;

            //weather api

            return View();
        }
    }
}
