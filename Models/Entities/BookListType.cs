namespace LibsterFinalProj.Models.Entities; 
public enum BookListType
{
  Catalog = 0, //Represents all books in a user's library catalog 
  Checkouts = 1, //Books that the user loans out to others -- to be returned to 
  Archive = 2, //Books removed from user's library; kept for record-keeping - to be retured to
  Custom = 3 //Custom user-created lists 
}