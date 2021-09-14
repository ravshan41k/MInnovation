using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MInnovation.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Interval { get; set; }
        public string Model { get; set; }
        public int Room { get; set; }
        public string Person { get; set; }
         public string MoreInformation { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
