using Microsoft.AspNetCore.Identity;
using Services.AuthAPI.Data;
using Services.AuthAPI.Models;
using Services.AuthAPI.Models.Dto;
using Services.AuthAPI.Services.Interfaces;

namespace Services.AuthAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDBContext _dbContext;
        private readonly RoleManager<IdentityUser> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(AppDBContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityUser> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Register(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
