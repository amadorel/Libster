using LibsterFinalProj.Models.Entities; 

public interface IBookListRepository
{
    Task<List<BookList>> ReadAllAsync();
    Task<BookList?> ReadByIdAsync(int id);
    Task CreateAsync(BookList newBookList);
    Task UpdateAsync(int id, BookList updatedBookList);
    Task DeleteAsync(int id);
}