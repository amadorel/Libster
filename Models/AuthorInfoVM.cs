using System.ComponentModel.DataAnnotations; 

/// <summary>
/// View model with Author data that should be handled/interacted by form
/// </summary>
public class AuthorInfoVM
{
  [Required(AllowEmptyStrings = true)] //Author does not need to be added for a book to be added to DB
  public string FullName {get; set;} = ""; //Take input as Full Name, split on the database side
}