using GraduationApp.Application.Repositories.Abstracts;
using GraduationApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Application.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext dbContext;
        internal DbSet<T> DbSet { get; set; }
        public GenericRepository(AppDbContext appDbContext) 
        {
            this.dbContext = appDbContext;
            this.DbSet = this.dbContext.Set<T>();
        }
        public virtual Task<bool> AddEntity(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return this.DbSet.ToListAsync();
        }

        public virtual Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateEntity(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
