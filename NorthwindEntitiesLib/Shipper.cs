using System.Collections.Generic;

namespace Nise.Shared
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string ShipperName { get; set; } 
        public string Phone { get; set; } 

        // related entities
        public ICollection<Order> Orders { get; set; } 
    }
}