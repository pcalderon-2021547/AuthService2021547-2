using AuthService2021547.Domain.Entitis;

namespace AuthService2021547.Domain.Interface;

public interface IUserRepository
{

    Task<User> CreateAsync(User user);    
    Task<User> GetByIDAsync(string Id);    
    Task<User?> GetByEmialAsync(string email);    
    Task<User?> GetByUsernameAsync(string username);    
    Task<User?> GetByEmailVerificationTokenAsync(string token);    
    Task<User?> GetByPasswordResetTokenAsync(string token);    
    Task<bool> ExistByEmialAsync (string email);    
    Task<bool> ExistByUsernameAsync (string username);
    Task<User> UpdateAsync (User user);
    Task<bool> DeleteAsync (string id);
    Task UpdateUserRoleAsync (string userId, string roleId);    
}
