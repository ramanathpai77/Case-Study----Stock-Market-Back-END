using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockExchange.Entities
{
    public class Company
    {
        [Key]
        public string CCode { get; set; }

        public string CName { get; set; }

        public double Turnover { get; set; }


        public string CEO { get; set; }
        [ForeignKey("se")]
        public int SEId { get; set; }
        public StockExchanges se { get; set; }
    }
}
