
namespace SilverBear.WebMVC.Entities
{
    public class LaptopGpu
    {
        public int? LaptopID { get; set; }
        public Laptop Laptop { get; set; }
        public int? GpuID { get; set; }
        public Gpu Gpu { get; set; }
    }
}
