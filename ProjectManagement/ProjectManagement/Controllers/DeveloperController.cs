﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class DeveloperController : Controller
    {
        private bool Authorize()
        {
            if (Session["CurrentUser"] == null)
                return false;
            else
                return true;
        }
        
        public ActionResult ShowDeveloperPage()
        {
            if (!Authorize())
                return View("RedirectByUser", "Home");
            return View();
        }


    }
}