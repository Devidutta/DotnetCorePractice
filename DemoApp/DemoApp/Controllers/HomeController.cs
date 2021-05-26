﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "Devidutt" }); 
        }
    }
}