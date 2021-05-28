
using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class Laptop
    {
        public int? LaptopID { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public IList<LaptopRam> LaptopRams { get; set; }
        public IList<LaptopHardDisk> LaptopHardDiscs { get; set; }
        public IList<LaptopPowerSupply> LaptopPowerSupplies { get; set; }
        public IList<LaptopGpu> LaptopGpus { get; set; }
        public IList<LaptopPort> LaptopPorts { get; set; }
    }
}
