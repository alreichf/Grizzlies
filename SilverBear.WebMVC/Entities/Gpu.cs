
using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class Gpu
    {
        public int? GpuID { get; set; }
        public string Name { get; set; }
        public IList<LaptopGpu> LaptopGpus { get; set; }
    }
}
