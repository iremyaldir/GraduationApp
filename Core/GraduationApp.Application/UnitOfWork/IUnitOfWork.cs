using GraduationApp.Application.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Application.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IAnnouncementRepository AnnouncementRepository { get; }
        public IJobPostRepository JobPostRepository { get; }
        public ITermRepository TermRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public IUserRepository UserRepository { get; }
        public IAlumniRepository AlumniRepository { get; }

        Task CompleteAsync();
    }
}
