using Microsoft.AspNetCore.Mvc;
using MovieApp.AdminUI.Helpers;
using MovieApp.Application.Dtos.CategoryDtos;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.Domain.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MovieApp.AdminUI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly HttpClient _client;

        public MoviesController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Movie");
            var movies = JsonConvert.DeserializeObject<List<GetAllMovieDto>>(response);
            return View(movies);
        }

        [HttpGet]
        public async Task<IActionResult> CreateMovie()
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Categories = await GetCategoryAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieDto dto)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Categories = await GetCategoryAsync();

            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Movie", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Film eklenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Movies/Update/{id}")]
        public async Task<IActionResult> UpdateMovie(string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Categories = await GetCategoryAsync();
            var response = await _client.GetStringAsync("https://localhost:7265/api/Movie/" + id);
            var movie = JsonConvert.DeserializeObject<UpdateMovieDto>(response);
            return View(movie);
        }

        [HttpPost]
        [Route("/Movies/Update/{id}")]
        public async Task<IActionResult> UpdateMovie(UpdateMovieDto dto, string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Categories = await GetCategoryAsync();
            if(dto.Id != Guid.Parse(id))
            {
                ModelState.AddModelError(string.Empty, "Id uyuşmuyor");
                return View(dto);
            }

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("https://localhost:7265/api/Movie/" + id, jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Film güncellenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Movies/Delete/{id}")]
        public async Task<IActionResult> RemoveMovie(Guid id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Movie/" + id);
            var movie = JsonConvert.DeserializeObject<GetByIdMovieDto>(response);
            return View(movie);
        }

        [HttpPost]
        [Route("/Movies/Delete/{id}")]
        public async Task<IActionResult> RemoveMovie(string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:7265/api/Movie/" + id),
                Content = new StringContent(JsonConvert.SerializeObject(new { Id = id }), Encoding.UTF8, "application/json")
            };

            var response = await _client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Film güncellenirken bir hata oluştu.");
            return View();
        }

        private async Task<List<GetAllCategoryDto>> GetCategoryAsync()
        {
            var categoryResponse = await _client.GetStringAsync("https://localhost:7265/api/Category");
            return JsonConvert.DeserializeObject<List<GetAllCategoryDto>>(categoryResponse);
        }
    }
}
