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
    public class FoodService : Service<Food>,IFoodService
    {
        public FoodService(IUnitOfWork unitOfWork, IRepository<Food> repository) : base(unitOfWork,repository)
        {
        }
    }
}
