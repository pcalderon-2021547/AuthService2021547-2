using AuthService2021547.Domain.Entitis;
namespace AuthService2021547.Domain.Interface;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync (string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyCollection<User>> GetUsersByRolesAsync(string roleName);
    Task<IReadOnlyCollection<string>> GetUserRoleNameAsync(string userId);
}