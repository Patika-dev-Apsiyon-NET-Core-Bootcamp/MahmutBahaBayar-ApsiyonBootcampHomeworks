using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.WebUI.DTOs
{
    public class MenuWithRestaurant:MenuDto
    {
        public List<MenuDto> Menus { get; set; }
    }
}
