using GraduationApp.Application.Repositories.Abstracts;
using GraduationApp.Domain.Entities;
using GraduationApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Application.Repositories.Concretes
{
    public class AlumniRegistrationRepository : GenericRepository<AlumniRegistration>, IAlumniRegistrationRepository
    {
        public AlumniRegistrationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public override Task<List<AlumniRegistration>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<AlumniRegistration> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);

        }

        public override async Task<bool> AddEntity(AlumniRegistration entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateEntity(AlumniRegistration entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if (existdata != null)
                {
                    existdata.AlumniStudentNo = entity.AlumniStudentNo;
                    existdata.RegistrationCode = entity.RegistrationCode;
                    
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == id);
            if (existdata != null)
            {
                DbSet.Remove(existdata);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
