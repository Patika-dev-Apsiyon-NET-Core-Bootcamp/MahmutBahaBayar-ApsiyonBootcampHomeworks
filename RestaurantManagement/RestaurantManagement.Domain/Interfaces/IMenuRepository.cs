using RestaurantManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain.Interfaces
{
    public interface IMenuRepository:IRepository<Menu>
    {
        Task<List<Menu>> GetMenuByRestaurant(int restaurantId);

    }
}
