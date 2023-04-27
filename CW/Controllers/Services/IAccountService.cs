using CW.Models;

namespace CW.Controllers.Services
{
    public interface IAccountService
    {
     
        Task RegisterUser(UsersModel user);

    }
}
