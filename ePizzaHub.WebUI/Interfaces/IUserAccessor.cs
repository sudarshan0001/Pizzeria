using Pizzeria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.WebUI.Interfaces
{
    public interface IUserAccessor
    {
        User GetUser();
    }
}
