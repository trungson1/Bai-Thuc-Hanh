using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh_20_02.Controllers;

    public class StudentController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
