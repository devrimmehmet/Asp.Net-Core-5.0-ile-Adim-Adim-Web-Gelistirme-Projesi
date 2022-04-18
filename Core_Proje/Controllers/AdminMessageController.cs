using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager =new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "devrimmehmet@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "devrimmehmet@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            p.Receiver = "devrimmehmet@gmail.com";
            p.SenderName = "Devrim Mehmet Pattabanoğlu";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
