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
    public class UserPrivacySettingRepository : GenericRepository<UserPrivacySetting>, IUserPrivacySettingRepository
    {
        public UserPrivacySettingRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public override Task<List<UserPrivacySetting>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<UserPrivacySetting> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);

        }

        public override async Task<bool> AddEntity(UserPrivacySetting entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                return true;

            }catch(Exception ex) 
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateEntity(UserPrivacySetting entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if(existdata != null)
                {
                    existdata.Name = entity.Name;
                    existdata.SettingCode = entity.SettingCode;
                   
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception ex) 
            {
                throw ex;
            }
        }

        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == id);
            if(existdata != null)
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
