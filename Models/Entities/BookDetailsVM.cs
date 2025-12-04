using System.ComponentModel.DataAnnotations; 
using LibsterFinalProj.Models.Entities; 

/// <summary>
/// View model with Book data that should be handled/interacted by forms
/// </summary>
public class BookDetailsVM
{
    public string Title {get; set;} = ""; 
    public List<AuthorInfoVM> Authors {get; set;} = new(); 
    public Genre Genre {get; set;}
    [Display(Name = "Publication Year")]
    public int PublicationYear {get; set;} 
    public string ISBN {get; set;} = "";
}