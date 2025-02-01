using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using MovieApp.Application.Dtos.CategoryDtos;
using MovieApp.Application.Dtos.MovieDtos;

namespace CategoryApp.AdminUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly HttpClient _client;

        public CategoryController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Category");
            var Category = JsonConvert.DeserializeObject<List<GetAllCategoryDto>>(response);
            return View(Category);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Category", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Kategori eklenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Category/Update/{id}")]
        public async Task<IActionResult> UpdateCategory(string id)
        {
            ViewBag.Movies = await GetMoviesAsync(id);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Category/" + id);
            var movie = JsonConvert.DeserializeObject<UpdateCategoryDto>(response);
            return View(movie);
        }

        [HttpPost]
        [Route("/Category/Update/{id}")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto dto, string id)
        {
            if(dto.Id != id)
            {
                ModelState.AddModelError(string.Empty, "Id uyuşmuyor");
                return View(dto);
            }

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("https://localhost:7265/api/Category/" + id, jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Kategori güncellenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Category/Delete/{id}")]
        public async Task<IActionResult> RemoveCategory(Guid id)
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Category/" + id);
            var movie = JsonConvert.DeserializeObject<GetByIdCategoryDto>(response);
            return View(movie);
        }

        [HttpPost]
        [Route("/Category/Delete/{id}")]
        public async Task<IActionResult> RemoveCategory(string id)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:7265/api/Category/" + id),
                Content = new StringContent(JsonConvert.SerializeObject(new { Id = id }), Encoding.UTF8, "application/json")
            };

            var response = await _client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Kategori güncellenirken bir hata oluştu.");
            return View();
        }

        private async Task<List<GetAllMovieDto>> GetMoviesAsync(string id)
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Movie/category/" + id);
            return JsonConvert.DeserializeObject<List<GetAllMovieDto>>(response);
        }
    }
}
