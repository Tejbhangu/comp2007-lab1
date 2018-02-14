using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
            //GET: Details?hardware=[value]
        public ActionResult Details(string hardware)
            {
            ViewBag.Hardware = hardware;
                return View();
            }
    }
}