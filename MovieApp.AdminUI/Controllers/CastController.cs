using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Application.Dtos.MovieDtos;

namespace CastApp.AdminUI.Controllers
{
    public class CastController : Controller
    {
        private readonly HttpClient _client;

        public CastController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Cast");
            var Cast = JsonConvert.DeserializeObject<List<GetAllCastDto>>(response);
            return View(Cast);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCast()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Cast", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Oyuncu eklenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Cast/Update/{id}")]
        public async Task<IActionResult> UpdateCast(string id)
        {
            ViewBag.Movies = await GetMoviesAsync(id);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Cast/" + id);
            var cast = JsonConvert.DeserializeObject<UpdateCastDto>(response);
            return View(cast);
        }

        [HttpPost]
        [Route("/Cast/Update/{id}")]
        public async Task<IActionResult> UpdateCast(UpdateCastDto dto, string id)
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
            var response = await _client.PutAsync("https://localhost:7265/api/Cast/" + id, jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Oyuncu güncellenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Cast/Delete/{id}")]
        public async Task<IActionResult> RemoveCast(Guid id)
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Cast/" + id);
            var cast = JsonConvert.DeserializeObject<GetByIdCastDto>(response);
            return View(cast);
        }

        [HttpPost]
        [Route("/Cast/Delete/{id}")]
        public async Task<IActionResult> RemoveCast(string id)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:7265/api/Cast/" + id),
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
