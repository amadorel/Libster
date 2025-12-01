using LibsterFinalProj.Models.Entities; 
using LibsterFinalProj.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace LibsterFinalProj.Controllers; 


[EnableCors]
[Route("api/[controller]")]
[ApiController]

public class LibsterAPIController : ControllerBase
{
  //This file's purpose is to contain the project's API calls, routes will be established as needed 

  private readonly IBookRepository _bookRepo; 
  private readonly IBookListRepository _bookListRepo;

  public LibsterAPIController(IBookRepository bookRepo, IBookListRepository bookListRepo)
  {
    _bookRepo = bookRepo; 
    _bookListRepo = bookListRepo; 
  }

  //GET: ALL BOOKS in user's catalog
  [HttpGet("books/catalog")]
  public async Task<IActionResult> Get()
  {
    return Ok( await _bookRepo.ReadAllAsync());
  }

  [HttpGet("books/{id}")] 
  public async Task<IActionResult> Get(int id)
  {
    var book = await _bookRepo.ReadByIdAsync(id);
    if (book == null)
    {
      return NotFound();
    }
    else 
    {
      return Ok(book);
    }
  }

}