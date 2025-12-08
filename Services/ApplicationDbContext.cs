using LibsterFinalProj.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace LibsterFinalProj.Services; 

/// <summary>
/// Standard ApplicationDbContext class for Libster; inherits from IdentityDbContext to establish Identity UI throughout project. Establishes DbSets of each entity: Books, Authors, and BookLists
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
  
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
  {}
   
  //DBset for each entity - other than users, whcih Identity UI will handle this
  public DbSet<Book> Books {get; set;}
  public DbSet<Author>? Authors {get; set; }  //Nullable list, not required 
  public DbSet<BookList> BookLists {get; set; }  

}

