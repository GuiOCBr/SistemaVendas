using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Register(int? id)  // PEGANDO AS CATEGORIAS LISTADAS 
        { 
            CategoryViewModel categoryViewModel = new CategoryViewModel();
          
            if (id != null)
            {
                var entities = appContext.Category.Where(x => x.Code == id).FirstOrDefault();
                categoryViewModel.Code = entities.Code;
                categoryViewModel.Description = entities.Description;
            }


            return View(categoryViewModel);
        }

        [HttpPost]

        public IActionResult Register(CategoryViewModel entities)
        {
            if (ModelState.IsValid)
            {
                Category objCategory = new Category()
                {
                    Code = entities.Code,
                    Description = entities.Description
                };

                if(entities.Code == null)
                {
                    appContext.Category.Add(objCategory);
                }
                else
                {
                    appContext.Entry(objCategory).State = EntityState.Modified;
                }

                appContext.SaveChanges();
            }

            else
            {
                return View(entities);
            }

            return RedirectToAction("Index");
        }
        
    }
}
// revisar 