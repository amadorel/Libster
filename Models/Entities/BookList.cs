using LibsterFinalProj.Models.Entities; 

/// <summary>
/// Class to represent collections of books a user owns
/// </summary>
public class BookList
{
   public int Id {get; set;}
   public string ListTitle {get; set;} =  ""; 
   public string ListDescription {get; set;} = "";
   public BookListType ListType {get; set;} 

   public ApplicationUser ListOwner {get; set;} = new ApplicationUser();
   public string UserId {get; set;} = ""; //From IdentityUser
   public List<Book> BooksInList {get; set;} = new List<Book>();

   //public byte[]? BookListCoverImage {get; set;} To be used at a later date
   
}