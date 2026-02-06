using AuthService2021547.Domain.Entitis;

namespace AuthService2021547.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken (User user);
}