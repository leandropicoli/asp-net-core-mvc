﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Course test application";
            ViewData["Aluno"] = "Leandro Picoli";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new SalesWebMvc.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
