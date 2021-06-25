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
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(RestaurantDbContext context) : base(context)
        {

        }

        
    }
}
