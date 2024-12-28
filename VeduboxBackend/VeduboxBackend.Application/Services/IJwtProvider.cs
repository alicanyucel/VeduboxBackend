using VeduboxBackend.Application.Features.Auth.Login;
using VeduboxBackend.Domain.Entities;

namespace VeduboxBackend.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
