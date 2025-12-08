using LibsterFinalProj.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 
using System.Threading.Tasks;

namespace LibsterFinalProj.Controllers; 

public class BookListController : Controller
{
  private readonly IBookListRepository _booklistRepo; 

  public BookListController(IBookListRepository booklistRepository)
  {
    _booklistRepo = booklistRepository; 
  }

  /// <summary>
  /// Task to collect data about BookLists and return
  ///them to user view. 
  /// </summary>
  /// <returns>booklistDetails --> summarization of booklist details to View</returns>
  public async Task<IActionResult> BookLists()
  {
    var allBookLists = await _booklistRepo.ReadAllAsync(); 

    var booklistDetails = allBookLists.Select(bookList => new BookListVM
    {
      Id = bookList.Id, 
      ListTitle = bookList.ListTitle, 
      ListDescription = bookList.ListDescription,
      NumberOfBooks = bookList.BooksInList.Count
    }); 
    return View(booklistDetails);
  }
}