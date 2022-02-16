using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Models
{
    public class Car
    {
        [Key]
        [Display(Name ="Reg number")]
        public string RegNumber { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Display(Name ="Car model")]
        public string CarModel { get; set; }

        public List<CarOwner> CarOwners { get; set; }
    }
}
