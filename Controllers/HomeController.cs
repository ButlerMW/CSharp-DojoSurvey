using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using System.Collections.Generic;
using DojoSurvey.Models;

namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ViewResult Index(string message)
        {
            return View();
        }
       
        [HttpPost("/result")]
        public IActionResult Result(User inputUser)
        {
            if(ModelState.IsValid)
            {
                return View(inputUser);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("/result")]
        public ViewResult Result()
        {
            return View();
        }

    }
}