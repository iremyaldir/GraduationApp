using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class Alumni: EntityBase
    {
        public Alumni() { }
        public Alumni(string firstName, string lastName, string emailAddress, string password, bool isVerified, string profileDescription, string sector, string company, string jobTitle, int alumniPrivacySettingId, int termId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            IsVerified = isVerified;
            ProfileDescription = profileDescription;
            Sector = sector;
            Company = company;
            JobTitle = jobTitle;
            AlumniPrivacySettingId = alumniPrivacySettingId;
            TermId = termId;
        }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? EmailAddress { get; set; }

        public string? Password { get; set; }

        public bool? IsVerified { get; set; }

        public string? ProfileDescription { get; set; }

        public string? Sector { get; set; }

        public string? Company { get; set; }

        public string? JobTitle { get; set; }

        public int AlumniPrivacySettingId { get; set; }

        public virtual AlumniPrivacySetting AlumniPrivacySetting { get; set; } = null!;


        //one to many relation btw alumni - department
        public ICollection<Department> Departments { get; set; }

        public virtual ICollection<AlumniRegistration> AlumniRegistrations { get; set; } = new List<AlumniRegistration>();

        //many to many relation btw alumni - role
        public virtual ICollection<AlumniRole> Alumnies { get; set; } = new List<AlumniRole>();

        //one to one relation btw alumni - term
        public int? TermId { get; set; }
        public virtual Term? Term { get; set; }
    }
}
