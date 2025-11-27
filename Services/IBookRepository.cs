using LibsterFinalProj.Models.Entities; 

public interface IBookRepository
{
    Task<ICollection<Book>> ReadAllAsync();
    Task<Book?> ReadByIdAsync(int id);
    Task<Book> CreateAsync(Book newBook);
    Task UpdateAsync(int oldId, Book updatedBook);
    Task DeleteAsync(int id);
}