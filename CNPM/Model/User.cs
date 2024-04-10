using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class User
    {
        public string UserId { get; set; }
     
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public virtual Account Account { get; set; }


    }
}
