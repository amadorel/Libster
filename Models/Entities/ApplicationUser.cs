using LibsterFinalProj.Models.Entities;
using Microsoft.AspNetCore.Identity;

//Inheriting from IdentityUser to acccess built-in authentication properties and user attributes
public class ApplicationUser : IdentityUser
{
    public string FirstName {get; set;} = String.Empty;
    public string LastName {get; set;} = String.Empty;
    public byte[]? ProfilePicture {get; set;} 
    public List<BookList> UserBookLists = new List<BookList>();

}