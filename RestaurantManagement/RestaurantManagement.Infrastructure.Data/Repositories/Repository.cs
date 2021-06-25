using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Domain.Interfaces;
using RestaurantManagement.Domain.Models;
using RestaurantManagement.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public readonly RestaurantDbContext _context;
        private readonly DbSet<TEntity> _dbset;
        public Repository(RestaurantDbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
           
            _dbset.Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);
        }
    }
}
