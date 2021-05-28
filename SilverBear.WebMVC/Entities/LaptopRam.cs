
namespace SilverBear.WebMVC.Entities
{
    public class LaptopRam
    {
        public int? LaptopID { get; set; }
        public Laptop Laptop { get; set; }
        public int? RamID { get; set; }
        public Ram Ram { get; set; }
    }
}
