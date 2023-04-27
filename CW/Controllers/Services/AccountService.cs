using CW.Controllers.Data;
using CW.Models;

namespace CW.Controllers.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _context;

        public AccountService(AppDbContext context)
        {
            _context = context;

        }



        public async Task RegisterUser(UsersModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

    }
}
