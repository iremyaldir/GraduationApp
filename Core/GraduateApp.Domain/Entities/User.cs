using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class User : EntityBase
    {
        public User() { }
        public User(string firstName, string lastName, string emailAddress, string password, bool isVerified, int departmentId, string entranceYear, string graduateYear, string informationDetail, int userPrivacySettingId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            IsVerified = isVerified;
            DepartmentId = departmentId;
            EntranceYear = entranceYear;
            GraduateYear = graduateYear;
            InformationDetail = informationDetail;
            UserPrivacySettingId = userPrivacySettingId;
        }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string EmailAddress { get; set; } = null!;

        public string Password { get; set; } = null!;

        public bool? IsVerified { get; set; }

        public int? DepartmentId { get; set; }

        public string? EntranceYear { get; set; }

        public string? GraduateYear { get; set; }

        public string? InformationDetail { get; set; }

        public int UserPrivacySettingId { get; set; }

        //one to many relation btw user - job post
        public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();

        public virtual UserPrivacySetting UserPrivacySetting { get; set; } = null!;

        public virtual ICollection<UserRegistration> UserRegistrations { get; set; } = new List<UserRegistration>();

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
