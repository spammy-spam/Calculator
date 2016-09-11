using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculo.Calculator.Website.Models;

namespace Calculo.Calculator.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string sum)
        {
            var calculation = new Calculation();

            calculation.Sum = sum;
            calculation.Answer = Calculator.Library.Calculator.Calculate(sum);


            return View(calculation);
        }
    }
}