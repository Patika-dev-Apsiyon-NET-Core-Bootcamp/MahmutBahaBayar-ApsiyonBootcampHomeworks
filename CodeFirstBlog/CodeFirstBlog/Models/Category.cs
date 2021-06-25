using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Models
{
    public class Category
    {
  
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BlogPost> blogPosts { get; set; }
    }
}
