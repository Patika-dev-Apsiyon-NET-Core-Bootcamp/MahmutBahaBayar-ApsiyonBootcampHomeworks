using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBlogService : IService<BlogViewModel>
    {
        List<BlogViewModel> GetAllByCategory(int categoryId);
        Task AddWithCategories(BlogViewModel blog);
        Tuple<CategoryViewModel,int> NumberOfBlogs();
    }
}
