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
    public class AlumniRepository: GenericRepository<Alumni>, IAlumniRepository
    {
        public AlumniRepository(AppDbContext appDbContext): base(appDbContext)
        {
        
        }
        public override Task<List<Alumni>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<Alumni> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);

        }

        public override async Task<bool> AddEntity(Alumni entity)
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
        public override async Task<bool> UpdateEntity(Alumni entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if (existdata != null)
                {
                    existdata.FirstName = entity.FirstName;
                    existdata.LastName = entity.LastName;
                    existdata.TermId = entity.TermId;
                    existdata.EmailAddress = entity.EmailAddress;
                    existdata.Password = entity.Password;
                    existdata.Sector = entity.Sector;
                    existdata.Company = entity.Company;
                    existdata.JobTitle = entity.JobTitle;
                    existdata.ProfileDescription = entity.ProfileDescription;
                    existdata.IsVerified = entity.IsVerified;
                    existdata.AlumniPrivacySettingId = entity.AlumniPrivacySettingId;
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
