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
        public IAlumniPrivacySettingRepository AlumniPrivacySettingRepository { get; private set; }
        public IAlumniRegistrationRepository AlumniRegistrationRepository { get; private set; }
        public IAlumniRoleRepository AlumniRoleRepository { get; private set; }
        public IUserPrivacySettingRepository UserPrivacySettingRepository { get; private set; }
        public IUserRegistrationRepository UserRegistrationRepository { get; set; }
        public IUserRoleRepository UserRoleRepository { get; set; }
        public IRoleRepository RoleRepository { get; set; }


        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            AnnouncementRepository = new AnnouncementRepository(appDbContext);
            JobPostRepository = new JobPostRepository(appDbContext);
            TermRepository = new TermRepository(appDbContext);
            DepartmentRepository = new DepartmentRepository(appDbContext);
            UserRepository = new UserRepository(appDbContext);
            AlumniRepository = new AlumniRepository(appDbContext);
            AlumniPrivacySettingRepository = new AlumniPrivacySettingRepository(appDbContext);
            AlumniRegistrationRepository = new AlumniRegistrationRepository(appDbContext);
            AlumniRoleRepository = new AlumniRoleRepository(appDbContext);
            UserPrivacySettingRepository = new UserPrivacySettingRepository(appDbContext);
            UserRegistrationRepository = new UserRegistrationRepository(appDbContext);
            UserRoleRepository = new UserRoleRepository(appDbContext);
            RoleRepository = new RoleRepository(appDbContext);
        }
        public async Task CompleteAsync()
        {
           await this.appDbContext.SaveChangesAsync();
        }
    }
}
