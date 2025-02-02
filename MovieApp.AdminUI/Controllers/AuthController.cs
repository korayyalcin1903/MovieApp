using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Dtos.UserDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieApp.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly HttpClient _client;

        public AuthController(HttpClient client)
        {
            _client = client;
        }

        [Route("auth/login")]
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        [Route("auth/login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Auth/login", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenDto>(responseContent);

                HttpContext.Session.SetString("AuthToken", tokenResponse.Token);
                return RedirectToAction("Index", "Movies");
            }
            ModelState.AddModelError(string.Empty, await response.Content.ReadAsStringAsync());
            return View(dto);
        }

        [HttpGet]
        [Route("auth/register")]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        [Route("auth/register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Auth/register", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Login", "Auth");
            }
            ModelState.AddModelError(string.Empty, await response.Content.ReadAsStringAsync());
            return View(dto);
        }

        [HttpGet]
        [Route("auth/logout")]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}
