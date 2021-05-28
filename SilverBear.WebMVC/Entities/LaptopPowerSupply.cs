
namespace SilverBear.WebMVC.Entities
{
    public class LaptopPowerSupply
    {
        public int? LaptopID { get; set; }
        public Laptop Laptop { get; set; }
        public int? PowerSupplyID { get; set; }
        public PowerSupply PowerSupply { get; set; }
    }
}
