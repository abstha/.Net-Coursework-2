using CW.Controllers.Data;
using CW.Controllers.Services;
using CW.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
  
        [HttpPost]
        [Route(template: "/api/User/register")]
        public async Task<IActionResult> Register([FromBody] UsersModel user)
        {
            if (ModelState.IsValid)
            {
                await _accountService.RegisterUser(user);

                return RedirectToAction("RegistrationSuccess");
            }
            return View(user);
        }
    }
}
