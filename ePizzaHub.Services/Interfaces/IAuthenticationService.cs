using Pizzeria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string Password);
        Task<bool> SignOut();
        User AuthenticateUser(string Username, string Password);
        User GetUser(string Username);
    }
}
