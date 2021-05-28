
using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class PowerSupply
    {
        public int? PowerSupplyID { get; set; }
        public string Name { get; set; }
        public IList<LaptopPowerSupply> LaptopPowerSupplies { get; set; }
    }
}
