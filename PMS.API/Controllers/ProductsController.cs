using Microsoft.AspNetCore.Mvc;
using PMS.API.Data;

namespace PMS.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly PMSDbContext _pmsDbContext;
        public ProductsController(PMSDbContext pmsDbContext)
        {
            _pmsDbContext = pmsDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
