using Pizzeria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetUserOrders(int UserId);
    }
}
