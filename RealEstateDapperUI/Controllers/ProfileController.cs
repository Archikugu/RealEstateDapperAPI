﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
