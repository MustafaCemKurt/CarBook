﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyCarbook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View();  
        }

    }
}
