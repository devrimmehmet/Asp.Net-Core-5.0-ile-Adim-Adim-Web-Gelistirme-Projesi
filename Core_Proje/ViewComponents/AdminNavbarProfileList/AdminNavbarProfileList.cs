using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.AdminNavbarProfile
{
    public class AdminNavbarProfileList:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public AdminNavbarProfileList(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.z = values.Name;
            ViewBag.z1 = values.Name + " " + values.Surname;
            ViewBag.z2 = values.ImageUrl;

            //weather api

            return View();
        }
    }
}



