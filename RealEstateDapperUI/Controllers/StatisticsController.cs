using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RealEstateDapperUI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region ActiveCategoryCount
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44374/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region ActiveEmployeeCount
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44374/api/Statistics/ActiveEmployeeCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData1;
            #endregion

            #region ApartmentCount
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44374/api/Statistics/ApartmentCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData2;
            #endregion

            #region AverageProductPriceByRent
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44374/api/Statistics/AverageProductPriceByRent");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData3;

            #endregion

            #region AverageProductPriceBySale
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44374/api/Statistics/AverageProductPriceBySale");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData4;
            #endregion

            #region AverageRoomCount
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44374/api/Statistics/AverageRoomCount");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData5;
            #endregion

            #region CategoryCount
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44374/api/Statistics/CategoryCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData6;
            #endregion

            #region CategoryNameByMaxProductCount
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44374/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData7;
            #endregion

            return View();
        }
    }
}
