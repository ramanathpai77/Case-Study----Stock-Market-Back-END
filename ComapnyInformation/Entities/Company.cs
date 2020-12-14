using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ComapnyInformation.Entities
{
    public class Company
    {
      [Key]
        public string CCode { get; set; }
        
        public string CName { get; set; }
    
        public double Turnover { get; set; }
   
     
        public string CEO { get; set; }
    
        public string BoD { get;  set; }
   
        public bool LInSE { get; set; }
   
        [ForeignKey("sector")]
        public int  SectorId{ get; set; }
        public Sector sector { get; set; }

        public string Description { get; set; }

        [ForeignKey("se")]
        public int SEId { get; set; }
        public StockExchange se { get; set; }






    }
}
