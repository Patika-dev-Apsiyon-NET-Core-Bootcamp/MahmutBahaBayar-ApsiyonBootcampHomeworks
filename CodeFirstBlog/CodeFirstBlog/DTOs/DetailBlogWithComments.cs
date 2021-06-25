using CodeFirstBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.DTOs
{
    public class DetailBlogWithComments
    {
        public BlogPost blogPost{ get; set; }
        public List<Comment> Comments { get; set; }
       
    }
}
