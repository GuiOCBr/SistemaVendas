using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entities;

namespace SistemaVenda.Controllers
{
    public class CategoryController : Controller
    {
        protected  ApplicationDbContext appContext;

        public CategoryController(ApplicationDbContext context)
        {
            appContext = context;
        }
        public IActionResult Index()
        {
            List<Category> categoryList = appContext.Category.ToList();
            appContext.Dispose();
            return View(categoryList);
        }
    }
}
