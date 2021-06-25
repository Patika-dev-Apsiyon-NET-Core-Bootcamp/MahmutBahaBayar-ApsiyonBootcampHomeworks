using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IFoodRepository Foods { get; }
        IMenuRepository Menus { get; }
        IRestaurantRepository Restaurants { get; }
        Task CommitAsync();
        void Commit();
    }
}
