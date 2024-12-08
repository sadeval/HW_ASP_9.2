using HW_ASP_9._2.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HW_ASP_9._2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Details(int id)
        {
            var category = Repository.GetCategoryById(id);
            if (category == null)
                return NotFound();

            var articles = Repository.GetArticlesByCategoryId(id);
            ViewBag.ArticleCount = articles.Count();

            return View((category, articles));
        }
    }
}
