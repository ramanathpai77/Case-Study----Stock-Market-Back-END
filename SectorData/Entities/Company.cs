using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SectorData.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public String CName { get; set; }
        
        public int Turnover { get; set; }
        [ForeignKey("sector")]
        public int SectorId { get; set; } 
        public Sector sector { get; set; }
    }
}
