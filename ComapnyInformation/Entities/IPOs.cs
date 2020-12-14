using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComapnyInformation.Entities
{
    public class IPOs
    {
        [Key]
        public string Id { get; set; }
        
        public string CName { get; set; }
   
        public string SE { get; set; }
      
        public  int PricePerShare { get; set; }
      
        public int TotalNoShares { get; set; }
  
        public DateTime OpenDate { get; set; }
   
        public string Remarks { get; set; }


    }
}
