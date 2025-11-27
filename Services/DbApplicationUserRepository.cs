using Microsoft.EntityFrameworkCore;
namespace LibsterFinalProj.Services;


public class DbApplicationUserRepository : IApplicationUserRepository
{
  private readonly ApplicationDbContext _db;
  public DbApplicationUserRepository(ApplicationDbContext db)
  {
    _db = db;
  }
  public async Task<ApplicationUser?> ReadByUserNameAsync(string username)
  {
    return await _db.Users.FirstOrDefaultAsync  (u => u.UserName ==
    username);
  }

}
