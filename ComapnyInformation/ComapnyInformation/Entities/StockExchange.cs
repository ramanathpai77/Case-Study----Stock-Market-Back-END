using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComapnyInformation.Entities
{
    public class StockExchange
    {
        [Key]
        public int SEId { get; set; }
        public string SEName {  get; set; }
        public string Remarks { get; set; }
        public string Address { get; set; }

    }
}
