using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DemoMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = "Xin chào " + FullName + "Đến từ" + Address;
        ViewBag.Massage = strOutput;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
