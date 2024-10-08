﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar() 
        {
            return PartialView();
        }

        public PartialViewResult PartialSideBar() 
        {
            return PartialView();
        }
    }
}