using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class JobPost: EntityBase
    {
        public JobPost() { }
        public JobPost(string title, string informationDetail, int userId)
        {
            Title = title;
            InformationDetail = informationDetail;
            UserId = userId;
        }
        public string Title { get; set; } = null!;

        public string? InformationDetail { get; set; }

        //one to many relation btw user - job post
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
