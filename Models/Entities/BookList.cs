using LibsterFinalProj.Models.Entities; 

public class BookList
{
   public int Id {get; set;}
   public string ListTitle {get; set;} =  ""; 
   public string ListDescription {get; set;} = "";
   public BookListType ListType {get; set;} 

   public ApplicationUser ListOwner {get; set;} = new ApplicationUser();
   public string UserId {get; set;} = ""; //From IdentityUser
   public List<Book> BooksInList = new List<Book>();
   public byte[]? BookListCoverImage {get; set;}
   
}