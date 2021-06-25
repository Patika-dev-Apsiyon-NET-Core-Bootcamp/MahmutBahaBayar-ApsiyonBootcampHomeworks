using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public int BlogPostId { get; set; }
        public User User { get; set; }
 
        public  BlogPost BlogPost { get; set; }
    }
}
