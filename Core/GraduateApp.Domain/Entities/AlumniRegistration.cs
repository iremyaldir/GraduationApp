using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class AlumniRegistration: EntityBase
    {
        public AlumniRegistration() { }
        public AlumniRegistration(string registrationCode, int alumniStudentNo)
        {
            RegistrationCode = registrationCode;
            AlumniStudentNo = alumniStudentNo;
        }

        public string? RegistrationCode { get; set; }

        public int? AlumniStudentNo { get; set; }

        public virtual Alumni? AlumniStudentNoNavigation { get; set; }
    }
}
