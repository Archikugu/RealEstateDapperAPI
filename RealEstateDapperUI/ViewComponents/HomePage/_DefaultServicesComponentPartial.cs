using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.HomePage
{
    public class _DefaultServicesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
