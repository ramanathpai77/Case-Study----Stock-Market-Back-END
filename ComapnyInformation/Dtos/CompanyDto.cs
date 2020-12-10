using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComapnyInformation.Dtos
{
    public class CompanyDto
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CName { get; set; }
        [Required]
        public double Turnover { get; set; }
        [Required]
        [MaxLength(30)]
        public string CEO { get; set; }
        [Required]
        public string BoD { get; set; }
        [Required]
        public bool LInSE { get; set; }
        [Required]
        public string Sector { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string StockCode { get; set; }
    }
}
