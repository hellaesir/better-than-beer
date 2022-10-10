using BtbApi.Controllers.Base;
using BtbApi.Security.JWT;
using BtbDomain.DTOs;
using BtbService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BtbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        IUserService _userService;
        IConfiguration _configuration;
        public UserController(IConfiguration configuration, IUserService userService, IActiveUserService activeUserService) : base(configuration, activeUserService)
        {
            _userService = userService;
            _configuration = configuration;
        }


        [HttpPost("login")]
        public async Task<ActionResult<AuthResponseDTO>> Login([FromBody] LoginRequestDTO login)
        {
            // Recupera o usuário
            UserAuthenticationDTO user = await _userService.Authenticate(login.Email, login.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Invalid user or password" });

            // Gera o Token
            var token = TokenService.GenerateToken(_configuration, user);
            var refreshToken = TokenService.GenerateRefreshToken();
            await TokenService.SaveRefreshToken(_userService, user.Email, refreshToken);

            // Retorna os dados
            return new AuthResponseDTO()
            {
                AccessToken = token,
                RefreshToken = refreshToken,
            };
        }
    }
}
