using CodeFirstBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.DTOs
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
