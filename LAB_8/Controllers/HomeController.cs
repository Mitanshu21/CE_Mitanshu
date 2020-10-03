using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using System.Text;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly Calcadd _calcadd;

        public HomeController(Calcadd calcadd)
        {
            _calcadd = calcadd;
        }
        public string Index()
        {
            return "Hello From Index";
        }

        public ViewResult test1()
        {
            Calc c = _calcadd.Add();
            ViewBag.calc = c;
            return View(c);
        }
        [HttpGet]
        public ActionResult test2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult test2_ans (string num1,string num2)
        {
            Calc c = new Calc();
            c.answer = Int32.Parse(num1) + Int32.Parse(num2);
            return View(c);
        }
    }
}
