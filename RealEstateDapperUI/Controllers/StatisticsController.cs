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
            ViewBag.averageProductPriceByRent = jsonData3.Substring(0, jsonData3.IndexOf('.') + 3);

            #endregion

            #region AverageProductPriceBySale
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44374/api/Statistics/AverageProductPriceBySale");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData4.Substring(0, jsonData3.IndexOf('.') + 4);
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

            #region CityNameByMaxProductCount
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44374/api/Statistics/CityNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData8;
            #endregion

            #region DifferentCityCount
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44374/api/Statistics/DifferentCityCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData9;
            #endregion

            #region EmployeeNameByMaxProductCount
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44374/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData10;
            #endregion

            #region LastProductPrice
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44374/api/Statistics/LastProductPrice");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData11;
            #endregion

            #region NewestBuildingYear
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44374/api/Statistics/NewestBuildingYear");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData12;
            ViewBag.newestBuildingYearDifference = int.Parse(ViewBag.newestBuildingYear) - DateTime.Now.Year;
            #endregion

            #region OldestBuildingYear
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44374/api/Statistics/OldestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData13;
            #endregion

            #region PassiveCategoryCount
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44374/api/Statistics/PassiveCategoryCount");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData14;
            #endregion

            #region ProductCount
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44374/api/Statistics/ProductCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData15;
            #endregion

            return View();
        }
    }
}
