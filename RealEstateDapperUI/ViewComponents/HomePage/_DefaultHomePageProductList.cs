using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
