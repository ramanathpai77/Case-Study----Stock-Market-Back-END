using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginCred.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set;}
        public bool UserType { get; set; } //admin means true 
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public bool Confirmed { get; set; }

    }
}
