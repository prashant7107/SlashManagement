using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class TeacherSource
    {
        public static List<TeacherforTeacherSource> TeacherSourc()
        {
            List<TeacherforTeacherSource> teachers = new List<TeacherforTeacherSource>();
            var context = new Db.SlashContext();
            var tes = context.Teachers_List.Where(t => t.Status == (bool) true).OrderBy(t => t.Teacher);
            foreach (var teacher in tes)
            {
                TeacherforTeacherSource te = new TeacherforTeacherSource();
                te.Id = teacher.Id;
                te.Teacher = teacher.Teacher;
                teachers.Add(te);
            }
            return teachers;
        }
    }
}
