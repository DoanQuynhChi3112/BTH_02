using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string StudentID, string TenSV )
        {
            string strResult = "Hello :" + StudentID + "-" + TenSV ; 
            ViewBag.Nhandulieu = strResult;
            return View();
        }
    }
}