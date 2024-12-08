using HW_ASP_9._2.Data;
using HW_ASP_9._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_ASP_9._2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = Repository.GetCategories();
            return View(categories);
        }
    }
}
