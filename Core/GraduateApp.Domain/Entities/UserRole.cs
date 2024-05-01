using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class UserRole : EntityBase
    {

        public UserRole() { }
        public UserRole(int userId, int roleId, DateTime createdDateTime)
        {
            UserId = userId;
            RoleId = roleId;
            CreatedDateTime = createdDateTime;
        }
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
