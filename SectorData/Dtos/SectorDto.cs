using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SectorData.Dtos
{
    public class SectorDto
    {
        public class Sector
        {
            
            public int SectorId { get; set; }
            [Required]
            [StringLength(30)]
            public String SectorName { get; set; }
        }
    }
}
