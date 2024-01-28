using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public PersonController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Xin chao : " + ps.FullName + " - " + ps.PersonID  + "!" ;
        ViewBag.Nhandulieu = strResult;
        return View();
    }
}
    