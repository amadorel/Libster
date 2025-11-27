using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibsterFinalProj.Models;

namespace LibsterFinalProj.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IApplicationUserRepository _userRepo;

    public HomeController(IApplicationUserRepository userRepo, ILogger<HomeController> logger)
    {
        _logger = logger;
        _userRepo = userRepo; 
    }

    public IActionResult Index()
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
