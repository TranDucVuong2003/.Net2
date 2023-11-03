using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Net2.Models;

namespace MVC.Net2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.thongBao = "Du lieu HttpGet";
        return View();
    }

    // public IActionResult Privacy()
    [HttpPost]
    public IActionResult Index(string FullName, string Email)
    {
        string strOutput = "Hello " + FullName.ToUpper() + "-" + Email;
        ViewBag.thongBao = strOutput;
        return View();
    }
}