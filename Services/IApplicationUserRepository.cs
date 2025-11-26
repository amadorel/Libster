
public interface IApplicationUserRepository
{
    Task<ApplicationUser?> ReadByUserNameAsync(string username);
}
