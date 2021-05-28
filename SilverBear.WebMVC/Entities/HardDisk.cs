using System.Collections.Generic;

namespace SilverBear.WebMVC.Entities
{
    public class HardDisk
    {
        public int? HardDiskID { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public IList<LaptopHardDisk> LaptopHardDiscs { get; set; }
    }
}