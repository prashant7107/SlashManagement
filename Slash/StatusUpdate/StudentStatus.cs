using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.StatusUpdate
{
   public class StudentStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public int Charge { get; set; }
        public int Paid_charge { get; set; }
        public int Remaining { get; set; }
        public Image Check { get; set; }

    }
}
