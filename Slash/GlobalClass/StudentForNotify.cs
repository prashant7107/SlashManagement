﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class StudentForNotify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Code { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public int TimeStart { get; set; }
        public int EndStart { get; set; }
        public int pendingCharge { get; set; }
    }
}
