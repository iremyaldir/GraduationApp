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
    public class AnnouncementRepository : GenericRepository<Announcement>, IAnnouncementRepository
    {
        public AnnouncementRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public override Task<List<Announcement>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<Announcement> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);

        }

        public override async Task<bool> AddEntity(Announcement entity)
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
        public override async Task<bool> UpdateEntity(Announcement entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if(existdata != null)
                {
                    existdata.Title = entity.Title;
                    existdata.Content = entity.Content;
                    existdata.Author = entity.Author;
                    existdata.CreatedDateTime = entity.CreatedDateTime;
                    existdata.UpdatedDateTime = entity.UpdatedDateTime;
                    existdata.AnnouncementDateTime = entity.AnnouncementDateTime;
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
