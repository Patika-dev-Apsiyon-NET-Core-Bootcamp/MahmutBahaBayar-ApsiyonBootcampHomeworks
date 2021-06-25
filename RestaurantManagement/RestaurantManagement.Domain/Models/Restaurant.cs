using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain.Models
{
     public  class Restaurant:Entity
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public  ICollection<Menu> Menus { get; set; }
    }
}
