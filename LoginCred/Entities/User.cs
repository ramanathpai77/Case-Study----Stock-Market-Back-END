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
        public string UserType { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Confirmed { get; set; }
        public string VerificationCode { get; set; }


    }
}
