using Sign_Identity.Domain.DTOs;
using Sign_Identity.Domain.Entities.Auth;

namespace Sign_Identity.Application.Services.AuthServices
{
    public interface IAuthService
    {
        public Task<AuthDTO> GenerateToken(User user);
    }
}
