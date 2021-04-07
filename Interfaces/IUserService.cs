using System.Collections.Generic;
using ServicingAPI.Classes;

namespace ServicingAPI.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(string userId);
    }
}