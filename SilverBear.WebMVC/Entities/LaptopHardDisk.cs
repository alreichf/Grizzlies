
namespace SilverBear.WebMVC.Entities
{
    public class LaptopHardDisk
    {
        public int? LaptopID { get; set; }
        public Laptop Laptop { get; set; }
        public int? HardDiscID { get; set; }
        public HardDisk HardDisk { get; set; }

    }
}
