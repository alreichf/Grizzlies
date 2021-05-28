
using System.Collections.Generic;
using SilverBear.WebMVC.Entities;

namespace SilverBear.WebMVC.Dtos
{
    public class Configuration
    {
        public Laptop Laptop { get; set; }
        public Ram Ram { get; set; }
        public HardDisk HardDisk { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public Gpu Gpu { get; set; }
        public Port Port { get; set; }
    }
}
