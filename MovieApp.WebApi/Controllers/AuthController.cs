using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MovieApp.Application.Dtos.UserDtos;
using MovieApp.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        public AuthController(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            if(dto.Email == null || dto.Password == null)
            {
                return BadRequest("Boş geçilemez");
            }
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user != null)
            {
                try
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, true);
                    if(result.Succeeded)
                    {
                        var token = GenerateJwtToken(_mapper.Map<GetUserDto>(user));
                        return Ok(new {token = token.Result});
                    } else
                    {
                        return Unauthorized("Şifre hatalı");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            } else
            {
                return Unauthorized("Kullanıcı bulunamadı");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            if (await _userManager.FindByEmailAsync(dto.Email) != null)
                return BadRequest("Bu e-posta adresi zaten kullanımda.");

            if (await _userManager.FindByNameAsync(dto.UserName) != null)
                return BadRequest("Bu kullanıcı adı zaten kullanımda.");

            var entity = _mapper.Map<User>(dto);

            try
            {
                var result = await _userManager.CreateAsync(entity, dto.Password);
                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors.Select(e => e.Description));
                }

                return Ok(new
                {
                    Message = "Kullanıcı başarıyla oluşturuldu.",
                    User = new
                    {
                        entity.Id,
                        entity.UserName,
                        entity.Email,
                        entity.PhoneNumber
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Kayıt sırasında bir hata oluştu.", Error = ex.Message });
            }
        }

        private async Task<string> GenerateJwtToken(GetUserDto user)
        {
            var appUser = _mapper.Map<User>(user);

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_configuration["AppSettings:Secret"]);

            var roles = await _userManager.GetRolesAsync(appUser);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(ClaimTypes.Name, user.UserName ?? string.Empty),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim("FirstName" ,user.FirstName ?? string.Empty),
                new Claim("LastName" ,user.LastName ?? string.Empty),
                new Claim("PhoneNumber", user.PhoneNumber ?? string.Empty)
            };

            foreach (var roleName in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleName));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "korayyalcin.com.tr",
                Audience = "korayyalcin.com.tr"
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
