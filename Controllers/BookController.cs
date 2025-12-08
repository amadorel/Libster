using Microsoft.AspNetCore.Mvc;
using LibsterFinalProj.Models.Entities;
using LibsterFinalProj.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace LibsterFinalProj.Controllers; 

public class BookController : Controller
{ 
   private readonly IBookRepository _bookRepo;
   private readonly ApplicationDbContext _db; 

    public BookController(IBookRepository bookRepo, ApplicationDbContext db)
    {
        _bookRepo = bookRepo;
        _db = db; 
    }

  public async Task<IActionResult> Catalog()
  {
      var allBooks = await _bookRepo.ReadAllAsync();
      ICollection<BookDetailsVM> NewBookDetailsVM = new List<BookDetailsVM>(); 
      foreach (Book book in allBooks)
       {
            BookDetailsVM newBookVM = new BookDetailsVM{
            Title = book.Title,
            PublicationYear = book.PublicationYear,
            Genre = book.Genre, 
            Authors = book.Authors.Select(a => new AuthorInfoVM {}).ToList(), 
            ISBN = book.ISBN 
          }; 
          NewBookDetailsVM.Add(newBookVM); 
       } 
        return View(NewBookDetailsVM);
  }

  //Take this and process the creation of the books...remember you also need to handle API logic
  [HttpPost("create-book")]
  public async Task<IActionResult> Create([FromBody] BookDetailsVM model) {
    
    if(!ModelState.IsValid) {
        return BadRequest(ModelState); 
    }

        Book book = new Book
      {
        Title = model.Title, 
        Genre = model.Genre, 
        PublicationYear = model.PublicationYear, 
        ISBN = model.ISBN, 
        Authors = model.Authors
            .Where(a => !string.IsNullOrWhiteSpace(a.FullName))
            .Select (a =>
            {
              var authorNameSplit = a.FullName.Trim().Split(' ', 2);
              return new Author
              {
                FirstName = authorNameSplit[0], 
                //Ternary syntax: condition ? true value : false value (based on condition)
                //Therefore-- if the split length is greater than one, the lastname is equal to value [1] in the arrray, otherwise it is an empty string
                LastName = authorNameSplit.Length > 1 ? authorNameSplit[1] : ""
              }; 
          }).ToList()
      }; 
    
      await _bookRepo.CreateAsync(book); 

    //Logic to add books to BookListType.Catalog: 
    var catalogBookList = await _db.BookLists.FirstOrDefaultAsync(l => l.ListType == BookListType.Catalog); 

    //If the catalog list is null, go ahead and create it and assign its type 
    if (catalogBookList == null)
    {
      catalogBookList = new BookList
      {
        ListType = BookListType.Catalog
      }; 

      _db.BookLists.Add(catalogBookList); //Add catalog to the database table of BookLists
    }
      catalogBookList.BooksInList.Add(book); //Add book to catalog upon successful creation  

      await _db.SaveChangesAsync(); //Final commit to database
      return Json(new
      {
        success = true,
        data = book, 
        message="Book created successfully"
      }); 
    }
}