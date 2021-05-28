
using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class Ram
    {
        public int? RamID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public IList<LaptopRam> LaptopRams { get; set; }
    }
}
