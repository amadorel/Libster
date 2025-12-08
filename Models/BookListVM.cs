using System.ComponentModel.DataAnnotations; 
using LibsterFinalProj.Models.Entities; 

/// <summary>
/// View model with Book data that should be handled/interacted with through forms
/// </summary>
public class BookListVM
{
    public int Id {get; set;}
    public string ListTitle {get; set;} = ""; 

    public string ListDescription {get; set;} = ""; 
    public int NumberOfBooks {get; set;} //Should be updated dynamically (later...)
}