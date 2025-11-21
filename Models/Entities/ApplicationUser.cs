using LibsterFinalProj.Models.Entities;
using Microsoft.AspNetCore.Identity;

//Inheriting from IdentityUser to acccess built-in authentication properties and user attributes
public class ApplicationUser : IdentityUser
{
    public string Username {get; set;} = "";
    public string FirstName {get; set;} = "";
    public string LastName {get; set;} = "";
    public byte[]? ProfilePicture {get; set;} 

    
}