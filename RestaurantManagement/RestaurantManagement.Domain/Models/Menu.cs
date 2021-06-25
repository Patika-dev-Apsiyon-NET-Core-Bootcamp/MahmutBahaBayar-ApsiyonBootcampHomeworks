using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Domain.Models
{
    public class Menu:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int RestaurantId { get; set; }
        public  Restaurant Restaurant { get; set; }

        public  ICollection<Food> Foods { get; set; }
    }
}
