using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;
using Project2BurgerMenu.Context;


namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            ViewBag.products = context.Products.Count();
            ViewBag.reservations = context.Reservations.Count();
            ViewBag.admins = context.Admins.Count();
            ViewBag.testimonials = context.Contacts.Count();
            ViewBag.deals = context.Products.Where(x => x.DealOfTheDay== true).Select(y => y.ProductName).Count();
            ViewBag.canceledReservations = context.Reservations.Where(x => x.ReservationStatus == "İptal Edildi").Count();
            ViewBag.categories = context.Categories.Count();
            ViewBag.mainDishes = context.Products.Where(x => x.CategoryId == 1).Count();
           
            ViewBag.avgPrice = context.Products.Select(x => x.Price).Average();
            ViewBag.maxPrice = context.Products.Select(x => x.Price).Max();
            ViewBag.lastReserve = context.Reservations.OrderByDescending(x => x.ReservationId).Select(x => x.Time).FirstOrDefault();
            return View();
        }
    }
}