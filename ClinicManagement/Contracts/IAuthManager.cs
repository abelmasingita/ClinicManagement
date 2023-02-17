using ClinicManagement.Data.Dto.User;
using Microsoft.AspNetCore.Identity;

namespace ClinicManagement.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(RegisterDto registerDto);
        Task<bool> Login(LoginDto loginDto);
    }
}
