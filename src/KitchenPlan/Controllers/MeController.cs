﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitchenPlan.Controllers
{
    public class MeController : Controller
    {
        //
        // GET: /Me/

        public ActionResult Headshot()
        {
            ViewBag.Title = "About Me";
            return View();
        }
        public ActionResult Bio()
        {
            ViewBag.Title = "About Me";
            return View();
        }
       
    }
}
