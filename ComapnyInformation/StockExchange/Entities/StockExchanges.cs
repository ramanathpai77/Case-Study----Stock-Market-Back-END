using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockExchange.Entities
{
    public class StockExchanges
    {
        [Key]
        public int SEId { get; set; }
        public string SEName { get; set; }
        public string Remarks { get; set; }
        public string Address { get; set; }

    }
}
