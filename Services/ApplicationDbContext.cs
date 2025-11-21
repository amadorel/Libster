using System.Security.Cryptography.X509Certificates;
using LibsterFinalProj.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibsterFinalProj.Services; 

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions options) : base(options) { }

  //DBset for each entity
  public DbSet<ApplicationUser> Users => Set<ApplicationUser>(); 
  public DbSet<Book> Books => Set<Book>();
  public DbSet<Author> Authors => Set<Author>(); 
  public DbSet<BookList> BookLists => Set<BookList>();   

}

