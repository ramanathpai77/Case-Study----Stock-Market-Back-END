using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComapnyInformation.Entities
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }
        public String SectorName { get; set; }

    }
}
