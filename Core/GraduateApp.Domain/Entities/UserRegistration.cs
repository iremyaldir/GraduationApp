using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class UserRegistration : EntityBase
    {
        public UserRegistration() { }
        public UserRegistration(string registrationCode, int userId)
        {
            RegistrationCode = registrationCode;
            UserId = userId;
        }
        public string RegistrationCode { get; set; } = null!;

        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
