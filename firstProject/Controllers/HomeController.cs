﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstProject.Controllers
{
    public class HomeController : Controller
    {

        firstProjectEntities _context = new firstProjectEntities();
        public ActionResult Index()
        {
            Console.WriteLine("Hello World");
            return View();
        }

        public ActionResult About()
        {
            _context.
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}