using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class AlumniRole : EntityBase
    {
        public AlumniRole() { }
        public AlumniRole(int alumniId, int roleId, int alumniRoleId)
        {
            AlumniId = alumniId;
            RoleId = roleId;
            AlumniRoleId = alumniRoleId;
        }
        public int? AlumniId { get; set; }

        public int? RoleId { get; set; }

        public int? AlumniRoleId { get; set; }
        //public virtual Alumni? AlumniStudentNoNavigation { get; set; }

        //public virtual Role? Role { get; set; }
    }
}
