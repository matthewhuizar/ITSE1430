﻿/*
 * Matthew Huizar
 * ITSE 1430
 * 12/8/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieLib.Web.Controllers 
{
    public class HomeController : Controller 
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}