using NuGet.Protocol.Plugins;

namespace LibsterFinalProj.Models.Entities; 

public class Book
{
    public int Id {get; set;}

    public int UserId {get; set;} //ID of user who added the book, present from IdentityUser
    public string Title {get; set;} = ""; 

    //A book can have multiple authors 
    public ICollection<Author> Authors {get; set;} = new List<Author>();
    public Genre Genre {get; set;}
    public int PublicationYear {get; set;} 
    public string ISBN {get; set;} = "";
}