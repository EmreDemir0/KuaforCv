﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KuaforCv.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.Title = "Esta ||  Kuaför & Güzellik & Berber Salonu - Biz Kimiz ?";
            return View();
        }
    }
}