using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComapnyInformation.Entities
{
    public class StockPrice
    {
       [Key]
        public DateTime datetime { get; set; }
        [ForeignKey("cc")]
        public String CompanyCode { get; set; }
        public Company cc { get; set; }

        
        [ForeignKey("se")]
        public int SEId { get; set; }
        public StockExchange se { get; set; }
         
        public int CurrentPrice { get; set; }
 
    }
}
