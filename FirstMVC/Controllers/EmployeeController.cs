using System.Runtime.Serialization;
using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            string strResult = "Xin Chào" + emp.MaNV + "-" + emp.TenNV + "-" + emp.Tuoi ;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}