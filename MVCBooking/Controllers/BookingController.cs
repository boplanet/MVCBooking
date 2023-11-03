using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;
using System.Diagnostics;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
       
    {
        private static List<HotelBooking> Rezervacije = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(Rezervacije);
        }
        public IActionResult Create()
        {
            HotelBooking rezervacija = new HotelBooking();
            return View(rezervacija);
        }
        public IActionResult CreateBooking(HotelBooking rezervacijaViewModel)
        {
            Rezervacije.Add(rezervacijaViewModel);
            return RedirectToAction("Create");
            //  return RedirectToAction("Index");
        }

    }
}