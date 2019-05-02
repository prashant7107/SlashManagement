using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class StudentRetrive
    {
        public static List<StudentforStudentRetrive> StudentRetriveName(String name)
        {

            List<StudentforStudentRetrive> Students = new List<StudentforStudentRetrive>();
            var context = new Db.SlashContext();
            var stds = context.Student_Entry.Where(p => p.Name.Contains(name)).OrderBy(s => s.Name);
            if (string.IsNullOrEmpty(name))
            {
                 stds =
                from s in context.Student_Entry
                orderby s.Name
                select s;
            }
            

                foreach (var student in stds)
                {
                    StudentforStudentRetrive std = new StudentforStudentRetrive();
                    std.Id = student.Id;
                    std.Name = student.Name;
                    std.Address = student.Address;

                    int subjctid = (int)student.CourseId;
                    var sub = context.Course_List.Find(subjctid);
                    std.Subject = sub.Subject;

                    std.Code = student.Code;

                    int teacherid = (int)student.TeacherId;
                    var te = context.Teachers_List.Find(teacherid);
                    std.Teacher = te.Teacher;

                    std.Contact = student.Contact_Number;
                    std.Email = student.Email_Id;

                    Students.Add(std);
                
                
            }
            return Students;
        }

        public static List<StudentforStudentRetrive> StudentRetriveCOde(String code)
        {

            List<StudentforStudentRetrive> Students = new List<StudentforStudentRetrive>();
            var context = new Db.SlashContext();
            var stds = context.Student_Entry.Where(p => p.Code.Contains(code)).OrderBy(s => s.Name);
            if (string.IsNullOrEmpty(code))
            {
                stds =
                from s in context.Student_Entry
                orderby s.Name
                select s;
            }

                foreach (var student in stds)
                {
                    StudentforStudentRetrive std = new StudentforStudentRetrive();
                    std.Id = student.Id;
                    std.Name = student.Name;
                    std.Address = student.Address;

                    int subjctid = (int)student.CourseId;
                    var sub = context.Course_List.Find(subjctid);
                    std.Subject = sub.Subject;

                    std.Code = student.Code;

                    int teacherid = (int)student.TeacherId;
                    var te = context.Teachers_List.Find(teacherid);
                    std.Teacher = te.Teacher;

                    std.Contact = student.Contact_Number;
                    std.Email = student.Email_Id;

                    Students.Add(std);

            }
            return Students;
        }
        public static List<StudentForNotify> StudentRetriveNotify()
        {
            DateTime referenceDate = System.DateTime.Today.AddDays(-4);

            List<StudentForNotify> Students = new List<StudentForNotify>();
            var context = new Db.SlashContext();
            var getStudents = context.Student_Entry.Where(a => (a.Charge != a.Paid_Charge) &&
                                                               (a.EntryTime > referenceDate))
                .OrderBy(a => a.EntryTime)
                .ThenBy(a => a.Pending_Charge);

            foreach (var student in getStudents)
            {
                StudentForNotify std = new StudentForNotify();
                std.Id = student.Id;
                std.Name = student.Name;
                std.Address = student.Address;

                int subjctid = (int)student.CourseId;
                var sub = context.Course_List.Find(subjctid);
                std.Subject = sub.Subject;

                std.Code = student.Code;


                std.Contact = student.Contact_Number;
                std.Email = student.Email_Id;

                std.TimeStart = (int)student.Time_Start;
                std.EndStart = (int) student.Time_End;

                std.pendingCharge = (int)student.Pending_Charge;
                Students.Add(std);

            }
            return Students;
        }
        
    }
}
