using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class HoursSouce
    {
        public static List<HoursforHourSouce> HourSourc()
        {
            List<HoursforHourSouce> hours = new List<HoursforHourSouce>();
            var context = new Db.SlashContext();
            var hrs =
                from h in context.Hours
                select h;
            foreach (var hour in hrs)
            {
                HoursforHourSouce hr = new HoursforHourSouce();
                hr.displaym = hour.displaym;
                hr.valuem = hour.valuem;
                hours.Add(hr);
            }
            return hours;
        }
    }
}
