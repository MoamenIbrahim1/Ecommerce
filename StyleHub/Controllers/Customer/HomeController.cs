using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StyleHub.Infrastructure._Data; //  √ﬂœ „‰ «”„ «·‹ Namespace » «⁄ «·‹ Context
using StyleHub.Core.Models;
using StyleHub.Infrastructure._Data.AppDbContext;

namespace StyleHub.Controllers.Customer
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context; // Õﬁ‰ ﬁ«⁄œ… «·»Ì«‰« 

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() //  ⁄œÌ· ·ÌﬂÊ‰ Async
        {
            // ”Õ» «·»Ì«‰«  „‰ «·œ« «»Ì“ „⁄ «·ﬂ« ÌÃÊ—Ì
            var products = await _context.Products.Include(p => p.Category).ToListAsync();

            //  „—Ì— „ÊœÌ· «·„‰ Ã«  ··„”«— «·„Õœœ
            return View("~/Views/Customer/Home/Index.cshtml", products);
        }
    }
}
