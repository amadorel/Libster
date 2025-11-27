using LibsterFinalProj.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace LibsterFinalProj.Services; 

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string> {
  
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
  {}
   
  //DBset for each entity - other than users, Identity will handle this
  public DbSet<Book> Books {get; set;}
  public DbSet<Author>? Authors {get; set; }  
  public DbSet<BookList> BookLists {get; set; }  

}

