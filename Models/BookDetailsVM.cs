using System.ComponentModel.DataAnnotations; 
using LibsterFinalProj.Models.Entities; 

/// <summary>
/// View model with Book data that should be handled/interacted with through forms
/// </summary>
public class BookDetailsVM
{
    [Required(ErrorMessage="Please enter a title!")]
    public string Title {get; set;} = ""; 

    public List<AuthorInfoVM> Authors {get; set;} = new(); //This is nullable by design 

    [Required(ErrorMessage="Please select a genre.")]
    public Genre Genre {get; set;}

    [Display(Name = "Publication Year")]
    [Required(ErrorMessage = "The publication year is required!")]
    [Range(0001, 2045, ErrorMessage="Year must be between 1 and 2045.")]
    public int PublicationYear {get; set;}

    [Required(AllowEmptyStrings=true)]
    public string ISBN {get; set;} = "";
}