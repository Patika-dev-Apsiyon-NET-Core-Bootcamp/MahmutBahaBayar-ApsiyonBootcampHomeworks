using RestaurantManagement.Application.Services;
using RestaurantManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Application.Interfaces
{ 
    public interface IFoodService :IService<Food>
    {
    }
}
