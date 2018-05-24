using GuestAndReservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace GuestAndReservations.Controllers
{
    public class ReservationsController : Controller
    {

        private ApplicationDbContext _context;
        public ReservationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var reservations = _context.Reservations.ToList();
            {
                return View(reservations);
            }
        }
        public ActionResult Details(int id)
        {
            var reservations = _context.Reservations.SingleOrDefault(r => r.ID == id);

            if (reservations == null)
                return HttpNotFound();

            return View(reservations);

        }
    }
}
