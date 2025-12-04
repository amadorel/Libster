using LibsterFinalProj.Models.Entities; 

public class Author
{
    public int Id {get; set;}
    //Foreign key to book 
    public int BookId {get; set;}
    public string FirstName {get; set;} = ""; 
    public string LastName {get; set;} = "";

    //public int NumberOfBooksInLibrary {get; set;}
    //public List<Book> BooksStored = new List<Book>(); //Books written by the author that are stored in the user's library -- Both of these are for future development
}