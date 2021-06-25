using RestaurantManagement.Application.Interfaces;
using RestaurantManagement.Domain.Interfaces;
using RestaurantManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Application.Services
{
    public class MenuService :Service<Menu>,IMenuService
    {
        public MenuService(IUnitOfWork unitOfWork, IRepository<Menu> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<List<Menu>> GetMenuByRestaurant(int restaurantId)
        {
            return await _unitOfWork.Menus.GetMenuByRestaurant(restaurantId);
        }
    }
}
