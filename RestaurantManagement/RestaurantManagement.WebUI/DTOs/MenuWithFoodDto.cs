using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.WebUI.DTOs
{
    public class MenuWithFoodDto : MenuDto
    {
         public List<FoodDto> Foods { get; set; }
    }
}
