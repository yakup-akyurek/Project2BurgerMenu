using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
        BurgerMenuContext context= new BurgerMenuContext();
        // GET: Default
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
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult TodaysOffer()
        {
            var values= context.Products.Where(x=>x.DealOfTheDay==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialMenu()
        {

            return PartialView();
        }
        public PartialViewResult PartialCategory() 
        {
            var values = context.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}