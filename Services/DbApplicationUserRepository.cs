using Microsoft.EntityFrameworkCore;
namespace LibsterFinalProj.Services;


public class DbUserRepository : IApplicationUserRepository
{
  private readonly ApplicationDbContext _db;
  public DbUserRepository(ApplicationDbContext db)
  {
    _db = db;
  }
  public async Task<ApplicationUser?> ReadByUserNameAsync(string username)
  {
    return await _db.Users.FirstOrDefaultAsync  (u => u.UserName ==
  username);
  }

}
