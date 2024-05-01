using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;

        public DateTime? LastSignedInDateTime { get; set; }
    }
}
