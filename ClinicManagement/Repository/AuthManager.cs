using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.User;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace ClinicManagement.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public AuthManager(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<bool> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            bool isValidUser = await _userManager.CheckPasswordAsync(user,loginDto.Password);

            if (user == null || isValidUser == false)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<IdentityError>> Register(RegisterDto registerDto)
        {
            var user = _mapper.Map<ApplicationUser>(registerDto);
            user.UserName = registerDto.Email;

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }
    }
}
