using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.Studentretrive
{
   public class StudentEdit
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int EducationId { get; set; }
        public int CourseId { get; set; }
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }
        public int TeacherId { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public byte[] Photo { get; set; }
    }
}
