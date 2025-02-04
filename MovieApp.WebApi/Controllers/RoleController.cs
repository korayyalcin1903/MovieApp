using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Dtos.RoleDtos;
using MovieApp.Domain.Entities;

namespace MovieApp.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public RoleController(RoleManager<Role> roleManager, IMapper mapper, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _roleManager.Roles.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            try
            {
                if(role != null)
                {
                    return Ok(role);
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound("Rol bulunamadı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDto dto)
        {
            var entity = _mapper.Map<Role>(dto);
            try
            {
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                var result = await _roleManager.CreateAsync(entity);
                if (result.Succeeded)
                {
                    return Ok(entity);
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto dto)
        {
            var entity = _mapper.Map<Role>(dto);
            try
            {
                var result = await _roleManager.UpdateAsync(entity);
                if (result.Succeeded)
                {
                    return Ok(entity);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            try
            {
                if (role != null)
                {
                    var result = await _roleManager.DeleteAsync(role);
                    if (result.Succeeded)
                    {
                        return Ok("Rol Silindi");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound("Rol bulunamadı");
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddRoleToUser(AddRoleToUser dto)
        {
            var user = await _userManager.FindByIdAsync(dto.UserId);
            var role = await _roleManager.FindByIdAsync(dto.RoleId);

            if(role.Name != null && user != null)
            {
                try
                {
                    var result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                    {
                        return Ok(result);
                    }
                } catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return NotFound("Kullanıcı veya Rol bulunamadı");
        }
    }
}
