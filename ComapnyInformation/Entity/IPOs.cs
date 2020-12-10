using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComapnyInformation.Entity
{
    public class IPOs
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CName { get; set; }
        [Required]
        public string SE { get; set; }
        [Required]
        public  int PricePerShare { get; set; }
        [Required]
        public int TotalNoShares { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
        [Required]
        public string Remarks { get; set; }


    }
}
