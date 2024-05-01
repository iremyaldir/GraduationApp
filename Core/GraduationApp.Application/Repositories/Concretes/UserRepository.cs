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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public override Task<List<User>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<User> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);

        }

        public override async Task<bool> AddEntity(User entity)
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
        public override async Task<bool> UpdateEntity(User entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if (existdata != null)
                {
                    existdata.FirstName = entity.FirstName;
                    existdata.LastName = entity.LastName;
                    existdata.EmailAddress = entity.EmailAddress;
                    existdata.EntranceYear = entity.EntranceYear;
                    existdata.IsVerified = entity.IsVerified;
                    existdata.Password = entity.Password;
                    existdata.GraduateYear = entity.GraduateYear;
                    existdata.InformationDetail = entity.InformationDetail;
                    existdata.DepartmentId = entity.DepartmentId;
                    existdata.UserPrivacySettingId = entity.UserPrivacySettingId;

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
