﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.HomePage
{
    public class _DefaultDiscountOfDayComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
