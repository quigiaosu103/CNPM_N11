using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string HashedPassword { get; set; }
        public string AvatarUrl { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
