using CW.Controllers.Data;
using CW.Controllers.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CW.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarsService _carsService;
        public CarController(ICarsService carsService)
        {
            _carsService = carsService;
        }
        public IActionResult Index()
        {
            var data = _carsService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
