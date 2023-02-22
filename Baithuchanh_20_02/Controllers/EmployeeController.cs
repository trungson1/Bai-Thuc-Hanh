using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh_20_02.Controllers;

    public class Employee : Controller 
    {
        public IActionResult Home()
        {
            return View();
        }
    }
