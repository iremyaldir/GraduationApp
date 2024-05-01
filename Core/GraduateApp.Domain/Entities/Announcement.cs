using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class Announcement: EntityBase
    {
        public Announcement() { }
        public Announcement(string title, string content, string author, DateTime updatedDateTime, DateTime announcementDateTime)
        {
            Title = title;
            Content = content;
            Author = author;
            UpdatedDateTime = updatedDateTime;
            AnnouncementDateTime = announcementDateTime;
        }
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string Author { get; set; } = null!;
        public DateTime? UpdatedDateTime { get; set; }

        public DateTime? AnnouncementDateTime { get; set; }
    }
}
