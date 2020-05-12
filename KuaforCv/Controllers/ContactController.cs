using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KuaforCv.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Title = "Esta ||  Kuaför & Güzellik & Berber Salonu - İletişim ";

            return View();
        }
    }
}