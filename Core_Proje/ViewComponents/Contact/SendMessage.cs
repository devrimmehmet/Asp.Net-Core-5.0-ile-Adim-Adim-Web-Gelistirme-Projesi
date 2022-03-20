using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
