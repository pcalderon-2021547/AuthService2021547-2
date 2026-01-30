using AuthService2021547.Application.DTOs;

namespace AuthService2021547.Application.Interface;

public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRoleAsync (string userId, string rolName);
    Task<IReadOnlyList<string>> GetUserRolesAsync(string userId);
    Task<IReadOnlyList<UserResponseDto>> GetUserByRoleAsync(string roleName);
}