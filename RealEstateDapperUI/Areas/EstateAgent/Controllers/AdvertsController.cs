using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateDapperUI.Dtos.ProductDtos;

namespace RealEstateDapperUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class AdvertsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdvertsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
            id = 1;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Products/ProductAdvertslistByEmployee?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
