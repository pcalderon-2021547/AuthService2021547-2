using AuthService2021547.Domain.Entitis;
namespace AuthService2021547.Domain.Interfaces;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUsersByRolesAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNameAsync(string userId);
}