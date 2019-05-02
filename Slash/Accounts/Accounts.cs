using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.Accounts
{
    public class Accounts
    {
        public string name { get; set; }
        public string subject { get; set; }
        public string code { get; set; }
        public Int64 contactnumber { get; set; }
        public string emailid { get; set; }
        public int charge { get; set; }
       
        public int ammount { get; set; }
        public int pendingAmmount { get; set; }

    }
}
