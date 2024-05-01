using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class Role: EntityBase
    {
        public Role() { }
        public Role(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }
        public string? Name { get; set; }

        public bool? IsAdmin { get; set; }

        //many to many relation btw alumni - role
        public virtual ICollection<AlumniRole> Roles { get; set; } = new List<AlumniRole>();
    }
}
