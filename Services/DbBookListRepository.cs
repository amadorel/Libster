using LibsterFinalProj.Models.Entities; 
using LibsterFinalProj.Services; 
using Microsoft.EntityFrameworkCore; 

public class DbBookListRepository : IBookListRepository
{
    private readonly ApplicationDbContext _db;
    public DbBookListRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<BookList>> ReadAllAsync()
    {
        return await _db.BookLists!.ToListAsync();
    }

    public async Task<BookList?> ReadByIdAsync(int id)
    {
        return await _db.BookLists!.FindAsync(id);
    }

    public async Task CreateAsync(BookList newBookList)
    {
        _db.BookLists!.Add(newBookList);
        await  _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(int id, BookList bookList)
    {
        var bookListToUpdate = await _db.BookLists!.FindAsync(id);
        if (bookListToUpdate != null)
        {
            //Omitting Id, ListOwner/UserId, and ListType as these values should not be updated 
            bookListToUpdate.ListTitle = bookList.ListTitle;
            bookListToUpdate.ListDescription = bookList.ListDescription;
            bookListToUpdate.BooksInList = bookList.BooksInList;

            await _db.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(int id)
    {
        var bookListToDelete = await ReadByIdAsync(id);
        if (bookListToDelete != null)
        {
            _db.BookLists.Remove(bookListToDelete);
            await _db.SaveChangesAsync();
        }
    }
}