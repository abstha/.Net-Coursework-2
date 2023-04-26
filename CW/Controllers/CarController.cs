using CW.Controllers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CW.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;
        public CarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Cars.ToList();
            return View(data);
        }
    }
}
