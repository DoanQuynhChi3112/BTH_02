using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class BTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string hesoA, string hesoB)
        {
            double hs1 =0, hs2 =0, Tong = 0;
            string Result;
            if(!String.IsNullOrEmpty(hesoA)) hs1 = Convert.ToDouble(hesoA);
            if(!String.IsNullOrEmpty(hesoB)) hs2 = Convert.ToDouble(hesoB);
            Tong = hs1+hs2;
            Result = "Tong 2 so : " + Tong  ;
            ViewBag.Nhandulieu = Result;
            return View();
        }

    }
}