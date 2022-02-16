using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Models
{
    public class CarOwner
    {
        public string CarRegNumber { get; set; }
        public Car Car { get; set; }

        public int OwnerId { get; set; }
        public Person Person { get; set; }
    }
}
