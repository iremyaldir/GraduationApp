using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Application.Repositories.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<bool> AddEntity(T Entity);
        Task<bool> UpdateEntity(T Entity);
        Task<bool> DeleteEntity(int id); 
    }
}
