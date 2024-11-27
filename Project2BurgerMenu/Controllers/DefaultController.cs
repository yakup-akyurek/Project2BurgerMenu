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
            var values=context.Products.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialCategory() 
        {
            var values = context.Categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery()
        {
            var products = context.Products.Take(6).ToList();
            return PartialView(products);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Onay bekleniyor";
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialLocation()
        {
            ViewBag.mapLocation = context.Abouts.Select(x => x.MapLocation).FirstOrDefault();
            return PartialView();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            contact.IsRead = false;
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialContact()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
    }
}