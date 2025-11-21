using Microsoft.AspNetCore.Mvc;

namespace LibsterFinalProj.Controllers; 

public class BookListController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}