using HW_ASP_9._2.Data;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP_9._2.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Details(int id)
        {
            var article = Repository.GetArticleById(id);
            if (article == null)
                return NotFound();

            return View(article);
        }
    }
}
