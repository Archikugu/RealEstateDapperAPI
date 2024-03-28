using Microsoft.AspNetCore.Mvc;
using RealEstateDapperUI.Services;

namespace RealEstateDapperUI.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;
        public _EstateAgentDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;

            #region Statistics1 - ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44374/api/EstateDashboardStatistics/AllProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData1;
            #endregion


            #region Statistics2 - EmlakçınınToplamİlanSayısı
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44374/api/EstateDashboardStatistics/ProductCountByEmployeeId?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeByProductCount = jsonData2;
            #endregion

            #region Statistics3 - AktifİlanSayısı
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44374/api/EstateDashboardStatistics/ProductCountByStatusTrue?id=" + id);
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.activeProductCount = jsonData3;
            #endregion

            #region Statistics4 - PasifİlanSayısı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44374/api/EstateDashboardStatistics/ProductCountByStatusFalse?id=" + id);
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.passiveProductCount = jsonData4;
            #endregion

            return View();
        }
    }
}
