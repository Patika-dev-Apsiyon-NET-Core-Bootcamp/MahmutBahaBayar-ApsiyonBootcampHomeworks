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
   public class RestaurantService:Service<Restaurant>,IRestaurantService
    {
        public RestaurantService(IUnitOfWork unitOfWork, IRepository<Restaurant> repository) : base(unitOfWork, repository)
        {
        }

    }
}
