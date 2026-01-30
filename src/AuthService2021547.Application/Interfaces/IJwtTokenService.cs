using AuthService2021547.Domain.Entitis;

namespace AuthService2021547.Application.Interface;

public interface IjetTokenService
{
    string GenerateToken (User user);
}