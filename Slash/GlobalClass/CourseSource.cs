using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class CourseSource
    {
        public static List<CourseforCourseSource_> CourseSourc()
        {
            List<CourseforCourseSource_> courses = new List<CourseforCourseSource_>();
            var context = new Db.SlashContext();
            var crs = context.Course_List.Where(c => c.Status == (bool) true).OrderBy(c => c.Subject);
                //from c in context.Course_List
                //where c.Status = (bool)true
                //orderby c.Subject
                //select c;
            foreach (var course in crs)
            {
                CourseforCourseSource_ cr = new CourseforCourseSource_();
                cr.Id = course.Id;
                cr.Subject = course.Subject;
                courses.Add(cr);
            }
            return courses;
        }
    }
}
