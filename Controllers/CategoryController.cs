using Microsoft.AspNetCore.Mvc;

namespace SistemaVenda.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
