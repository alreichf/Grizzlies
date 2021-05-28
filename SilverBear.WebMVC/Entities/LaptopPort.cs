
namespace SilverBear.WebMVC.Entities
{
    public class LaptopPort
    {
        public int? LaptopID { get; set; }
        public Laptop Laptop { get; set; }
        public int? PortID { get; set; }
        public Port Port { get; set; }
    }
}
