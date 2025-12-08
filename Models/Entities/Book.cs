using NuGet.Protocol.Plugins;

namespace LibsterFinalProj.Models.Entities; 

/// <summary>
/// Class to represent individual books 
/// </summary>
public class Book
{
    public int Id {get; set;}

    public int UserId {get; set;} //ID of user who added the book, present from IdentityUser

    public int BookListId {get; set;} //Hold the ID of BookLists book is a part of 
    public string Title {get; set;} = ""; 

    //A book can have multiple authors 
    public ICollection<Author> Authors {get; set;} = new List<Author>();
    public Genre Genre {get; set;}
    public int? PublicationYear {get; set;} 
    public string ISBN {get; set;} = "";
}