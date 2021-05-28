
using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class Port
    {
        public int? PortID { get; set; }
        public string Name { get; set; }
        public IList<LaptopPort> LaptopPorts { get; set; }
    }
}
