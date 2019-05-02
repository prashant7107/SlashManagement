using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
  public class EducationSource
    {
        public static List<EducationforEducationSource> EducationSourc()
        {
            List<EducationforEducationSource> educations = new List<EducationforEducationSource>();
            var context = new Db.SlashContext();
            var eds = context.Student_Education.Where(e => e.Status == (bool) true).OrderBy(e => e.Education);
            foreach (var education in eds)
            {
                EducationforEducationSource ed = new EducationforEducationSource();
                ed.Id = education.Id;
                ed.Educations = education.Education;
                educations.Add(ed);
            }
            return educations;
        }
    }
}
