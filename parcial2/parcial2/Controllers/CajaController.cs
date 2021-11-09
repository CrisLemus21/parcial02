using parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcial2.Controllers
{
    public class cajaController : Controller
    {
        // GET: caja
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Nosirve()
        {
            return View();
        }
        [HttpGet]
        public ActionResult sirve()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(caja cajita)
        {
            if (cajita.caj % 5 == 0)
            {
                return RedirectToAction("sirve");
            }
            else
            {
                return RedirectToAction("Nosirve");
            }
            return View();
        }
    }
}