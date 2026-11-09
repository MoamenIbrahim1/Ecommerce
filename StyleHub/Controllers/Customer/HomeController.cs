using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StyleHub.Infrastructure._Data; 
using StyleHub.Core.Models;
using StyleHub.Infrastructure._Data.AppDbContext;
using StyleHub.Infrastructure.UnitOfWork;
using StyleHub.Infrastructure.Repositories;
namespace StyleHub.Controllers.Customer
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {

            var products = await _unitOfWork.Products
    .GetAllAsync()
    .Include(p => p.Category)
    .ToListAsync();
            return View("~/Views/Customer/Home/Index.cshtml", products);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _unitOfWork.Products
         .GetAllAsync()
         .Include(p => p.Category)
         .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Customer/Home/product-detail.cshtml", product);
        }

    }
}
    