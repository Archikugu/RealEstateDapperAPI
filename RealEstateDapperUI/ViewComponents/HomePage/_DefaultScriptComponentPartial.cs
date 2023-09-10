using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.HomePage
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
