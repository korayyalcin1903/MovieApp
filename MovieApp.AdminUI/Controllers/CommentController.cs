using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using MovieApp.Application.Dtos.CommentDtos;
using MovieApp.Application.Dtos.MovieDtos;
using MovieApp.AdminUI.Helpers;

namespace CommentApp.AdminUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly HttpClient _client;

        public CommentController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Comment");
            var Comment = JsonConvert.DeserializeObject<List<GetAllCommentDto>>(response);
            return View(Comment);
        }

        [HttpGet]
        public async Task<IActionResult> CreateComment()
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Movies = await GetMoviesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDto dto)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Movies = await GetMoviesAsync();
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7265/api/Comment", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Yorum eklenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Comment/Update/{id}")]
        public async Task<IActionResult> UpdateComment(string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Movies = await GetMoviesAsync();
            var response = await _client.GetStringAsync("https://localhost:7265/api/Comment/" + id);
            var comment = JsonConvert.DeserializeObject<UpdateCommentDto>(response);
            return View(comment);
        }

        [HttpPost]
        [Route("/Comment/Update/{id}")]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto dto, string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            ViewBag.Movies = await GetMoviesAsync();
            if (dto.Id != id)
            {
                ModelState.AddModelError(string.Empty, "Id uyuşmuyor");
                return View(dto);
            }

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("https://localhost:7265/api/Comment/" + id, jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Yorum güncellenirken bir hata oluştu.");
            return View(dto);
        }

        [HttpGet]
        [Route("/Comment/Delete/{id}")]
        public async Task<IActionResult> RemoveComment(Guid id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var response = await _client.GetStringAsync("https://localhost:7265/api/Comment/" + id);
            var comment = JsonConvert.DeserializeObject<GetByIdCommentDto>(response);
            return View(comment);
        }

        [HttpPost]
        [Route("/Comment/Delete/{id}")]
        public async Task<IActionResult> RemoveComment(string id)
        {
            TokenHelper.AddAuthorizationHeader(_client, HttpContext);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:7265/api/Comment/" + id),
                Content = new StringContent(JsonConvert.SerializeObject(new { Id = id }), Encoding.UTF8, "application/json")
            };

            var response = await _client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Yorum güncellenirken bir hata oluştu.");
            return View();
        }

        private async Task<List<GetAllMovieDto>> GetMoviesAsync()
        {
            var response = await _client.GetStringAsync("https://localhost:7265/api/Movie/");
            return JsonConvert.DeserializeObject<List<GetAllMovieDto>>(response);
        }
    }
}
