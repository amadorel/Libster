using LibsterFinalProj.Models.Entities; 
using LibsterFinalProj.Services; 
using Microsoft.EntityFrameworkCore;

public class DbBookRepository : IBookRepository
{
  private readonly ApplicationDbContext _db; 

  public DbBookRepository(ApplicationDbContext db)
  {
    _db = db;
  }
    public async Task<ICollection<Book>> ReadAllAsync()
  {
      return await _db.Books.ToListAsync();
  }

  public async Task<Book?> ReadByIdAsync(int id)
  {
    return await _db.Books!.FindAsync(id);
  }

  public async Task<Book> CreateAsync(Book newBook)
  {
    await _db.Books.AddAsync(newBook);
    await _db.SaveChangesAsync();
    return newBook;
  }

  public async Task UpdateAsync(int oldId, Book updatedBook)
  {
    Book? bookToUpdate = await _db.Books!.FindAsync(oldId);
    if (bookToUpdate != null)
    {
      bookToUpdate.Title = updatedBook.Title;
      bookToUpdate.Authors = updatedBook.Authors;
      bookToUpdate.Genre = updatedBook.Genre;
      bookToUpdate.PublicationYear = updatedBook.PublicationYear;
      bookToUpdate.ISBN = updatedBook.ISBN;
      bookToUpdate.CoverImage = updatedBook.CoverImage;
      await _db.SaveChangesAsync();
    }
    else 
    {
      throw new Exception($"Book with id {oldId} not found, cannot update");
    }
  }

public async Task DeleteAsync(int id)
  {
    Book? bookToDelete = await _db.Books!.FindAsync(id);
    if (bookToDelete != null)
    {
      _db.Books.Remove(bookToDelete);
      await _db.SaveChangesAsync();
    }
  }
}
