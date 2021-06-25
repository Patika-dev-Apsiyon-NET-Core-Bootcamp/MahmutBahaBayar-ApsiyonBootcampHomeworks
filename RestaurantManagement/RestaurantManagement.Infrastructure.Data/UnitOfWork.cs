using RestaurantManagement.Domain.Interfaces;
using RestaurantManagement.Infrastructure.Data.Context;
using RestaurantManagement.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantDbContext _context;
        private  FoodRepository _foodRepository;
        private  MenuRepository _menuRepository;
        private  RestaurantRepository _restaurantRepository;

        public IFoodRepository Foods => _foodRepository = _foodRepository ?? new FoodRepository(_context);

        public IMenuRepository Menus => _menuRepository = _menuRepository ?? new MenuRepository(_context);

        public IRestaurantRepository Restaurants => _restaurantRepository = _restaurantRepository ?? new RestaurantRepository(_context);
        public UnitOfWork(RestaurantDbContext restaurantDbContext)
        {
            _context = restaurantDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
