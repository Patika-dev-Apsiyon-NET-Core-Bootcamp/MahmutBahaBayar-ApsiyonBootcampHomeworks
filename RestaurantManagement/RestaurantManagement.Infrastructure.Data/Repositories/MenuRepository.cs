using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Interfaces;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Infrastructure.Data.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {

        public MenuRepository(RestaurantDbContext context) : base(context)
        {

        }


        public async Task<List<Menu>> GetMenuByRestaurant(int restaurantId)
        {
            return await _context.Menus
                 .Where(i => i.RestaurantId == restaurantId)
                 .Include(f => f.Foods)
                 .ToListAsync();
        }

    }
}
