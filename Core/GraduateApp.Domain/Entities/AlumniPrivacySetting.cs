using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class AlumniPrivacySetting : EntityBase
    {
        public AlumniPrivacySetting() { }
        public AlumniPrivacySetting(string displayName, string settingCode)
        {
            DisplayName = displayName;
            SettingCode = settingCode;
        }
        public string? DisplayName { get; set; }

        public string? SettingCode { get; set; }

        public virtual ICollection<Alumni> Alumni { get; set; } = new List<Alumni>();
    }
}
