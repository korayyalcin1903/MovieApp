using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Dtos.UserDtos;
using MovieApp.Domain.Entities;

namespace MovieApp.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            if(users != null)
            {
                var result = _mapper.Map<List<GetUserDto>>(users);
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var User = await _userManager.FindByIdAsync(id);
            try
            {
                if(User != null)
                {
                    return Ok(User);
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound("Kullanıcı bulunamadı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserDto dto)
        {
            var user = await _userManager.FindByIdAsync(dto.Id);
            try
            {
                if (user != null)
                {
                    _mapper.Map(dto, user);

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return Ok(user);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var User = await _userManager.FindByIdAsync(id);
            try
            {
                if (User != null)
                {
                    var result = await _userManager.DeleteAsync(User);
                    if (result.Succeeded)
                    {
                        return Ok("Kullanıcı Silindi");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound("Kullanıcı bulunamadı");
        }
    }
}
