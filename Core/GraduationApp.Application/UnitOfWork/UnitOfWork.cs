using GraduationApp.Application.Repositories.Abstracts;
using GraduationApp.Application.Repositories.Concretes;
using GraduationApp.Domain.Entities;
using GraduationApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAnnouncementRepository AnnouncementRepository { get; private set; }
        public IJobPostRepository JobPostRepository { get; private set; }
        public ITermRepository TermRepository { get; private set; }
        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IAlumniRepository AlumniRepository { get; private set; }

        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            AnnouncementRepository = new AnnouncementRepository(appDbContext);
            JobPostRepository = new JobPostRepository(appDbContext);
            TermRepository = new TermRepository(appDbContext);
            DepartmentRepository = new DepartmentRepository(appDbContext);
            UserRepository = new UserRepository(appDbContext);
        }
        public async Task CompleteAsync()
        {
           await this.appDbContext.SaveChangesAsync();
        }
    }
}
