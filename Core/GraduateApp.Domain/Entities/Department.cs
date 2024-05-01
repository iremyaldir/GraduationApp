using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class Department : EntityBase
    {
        public Department() { }
        public Department(string departmentCode, string name, int alumniId)
        {
            DepartmentCode = departmentCode;
            Name = name;
            AlumniId = alumniId;
        }
        public string DepartmentCode { get; set; } = null!;

        public string Name { get; set; } = null!;

        //one to many relation btw alumni - department
        public int AlumniId { get; set; }
        public Alumni Alumni { get; set; }
    }
}
