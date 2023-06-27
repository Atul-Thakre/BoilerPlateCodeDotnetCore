using CourseAppWebApi.DTO.User;
using Microsoft.AspNetCore.Identity;

namespace CourseAppWebApi.Repository
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> RegisterUser(ApiUserDto userDto);
        Task<AuthresponseDto> Login(LoginDto logindto);
        Task<string> CreateRefreshToken();
        Task<AuthresponseDto> VerifyRefreshToken(AuthresponseDto request);
    }
}
