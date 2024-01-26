using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BlogDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Yazarlarımızın Blogları";
            var client = _httpClientFactory.CreateClient("UdemyCarBookAPI");
            var response = await client.GetAsync("https://localhost:7242/api/Blogs/GetAllBlogsWithAuthors");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(responseContent);
                return View(result);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Blog Detayı";
            var client = _httpClientFactory.CreateClient("UdemyCarBookAPI");
            var response = await client.GetAsync($"https://localhost:7242/api/Blogs/GetBlogWithAuthorById/{id}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultAllBlogsWithAuthorDto>(responseContent);
                return View(result);
            }
            return View();
        }
    }
}
