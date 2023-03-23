using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entities;
using SistemaVenda.Models;

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

        [HttpGet]
        public IActionResult Register(int? id) // revisar depois de onde está vindo esse parametro , acho que esse parametro serve para pegar a PK da classe categoryVIewModel
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();
          
            return View(categoryViewModel);
        }
    }
}
