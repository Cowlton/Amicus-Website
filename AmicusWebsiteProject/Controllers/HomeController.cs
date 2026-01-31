namespace AmicusWebsite;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AmicusWebsiteProject.Models;


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
    
    public IActionResult About()
    {
        return View();
    }

    public IActionResult OpenHouse()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
}
