using Pizzeria.Entities;
using Pizzeria.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Repositories.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Order> GetUserOrders(int UserId)
        {
            return appContext.Orders
               .Include(o => o.OrderItems)
               .Where(x => x.UserId == UserId).ToList();
        }
    }
}
