using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginCred.Entities
{
    public class ValidationResponse
    {
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Jwt { get; set; }
    }
}
