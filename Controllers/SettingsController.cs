﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyPos.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/Settings/Profile");
        }

        public IActionResult TwoFactorAuth()
        {
            return RedirectToPage("/Settings/TwoFactorAuth/Config");
        }
    }
}