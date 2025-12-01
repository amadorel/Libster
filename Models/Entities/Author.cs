using LibsterFinalProj.Models.Entities; 

public class Author
{
    public int Id {get; set;}
    public string FirstName {get; set;} = ""; 
    public string LastName {get; set;} = "";
    //public int NumberOFBooksInLibrary {get; set;}
    //public List<Book> BooksStored = new List<Book>(); //Books written by the author that are stored in the user's library
  
}