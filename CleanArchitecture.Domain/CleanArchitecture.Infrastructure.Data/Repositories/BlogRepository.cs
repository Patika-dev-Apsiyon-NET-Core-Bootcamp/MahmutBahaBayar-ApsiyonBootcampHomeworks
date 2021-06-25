using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {

        public BlogRepository(BlogDbContext context) : base(context)
        {

        }

        public async Task AddWithCategories(Blog blog)
        {
            _context.Categories.AttachRange(blog.Categories);
            _context.Tags.AttachRange(blog.Tags);

            await base.Add(blog);

        }

        public List<Blog> GetAllByCategory(int categoryId)
        {

            return _context.Blogs.Where(x => x.Categories.Any(y => y.Id == categoryId && y.Status)).ToList();
        }

        public Tuple<Category, int> NumberOfBlogs()
        {
            //şuna bak bir yaz ödev!!

            //var grouped = (from cat in _context.Categories
            //               join blog in _context.Blogs on cat.Id equals blog.Id
            //               group cat by cat.Blogs into g
            //               select new { Category = g.Key, Blog = g.Count() });
            //return Tuple.Create<Category, int>(new Category(),1);

            var categoryDetail = _context.Categories.FirstOrDefault();
            return Tuple.Create<Category, int>(categoryDetail, categoryDetail.Blogs.Count);
        }
    }
}
