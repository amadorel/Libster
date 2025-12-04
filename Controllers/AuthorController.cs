using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace LibsterFinalProj.Controllers; 

//At it's present state, this controller is not needed-- leaving for future development/if I choose to change the schema
public class AuthorController : Controller
{
  public IActionResult Index()
  {
    return View(); 
  }
}