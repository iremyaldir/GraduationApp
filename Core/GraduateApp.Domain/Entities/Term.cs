using GraduationApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationApp.Domain.Entities
{
    public class Term : EntityBase
    {
        public Term() { }
        public Term(int termYear, int alumniId)
        {
            TermYear = termYear;
            AlumniId = alumniId;
        }
        public int? TermYear { get; set; }

        //one to one relation btw alumni - term
        public int AlumniId { get; set; }
        public Alumni Alumni { get; set; }
    }
}
