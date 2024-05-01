using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class UserPrivacySetting : EntityBase
    {
        public UserPrivacySetting() { }
        public UserPrivacySetting(string name, string settingCode)
        {
            Name = name;
            SettingCode = settingCode;
        }
        public string? Name { get; set; }

        public string? SettingCode { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
