﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_Helpers.Controllers
{
    public class RenderPartialController : Controller
    {
        // GET: RenderPartial
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderPartial()
        {
            return View();
        }
    }
}