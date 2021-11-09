using parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcial2.Controllers
{
    public class CajaController : Controller
    {
        // GET: Caja
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult indexV()
        {
            return View();
        }
        [HttpGet]
        public ActionResult noSirve()
        {
            return View();
        }
        [HttpGet]
        public ActionResult sirve()
        {
            return View();
        }
        [HttpPost]
        public ActionResult indexV(caja ca)
        {
            if(ca.caj % 5 == 0)
            {
                return Redirect("sirve");

            }
            else
            {
                return Redirect("noSirve");
            }
            return View();
        }

    }
}