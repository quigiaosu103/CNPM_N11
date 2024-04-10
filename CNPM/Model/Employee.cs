using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class Employee : User
    {
        public string Email { get; set; }
        public string IdCard { get; set; }
        public string Position { get; set; }
        public long Salary { get; set; }
        public string WorkingTime { get; set; }
        public string ApplyDate { get; set; }

    }
}
