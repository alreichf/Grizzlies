
using System.Collections.Generic;

namespace SilverBear.WebMVC.Models
{
    public class ConfigurationsViewModel
    {
        public ConfigurationViewModel ConfigurationViewModel { get; set; }
        public IEnumerable<RamViewModel> RamViewModels { get; set; }
        public IEnumerable<HardDiskViewModel> HardDiscViewModels { get; set; }
        public IEnumerable<PowerSupplyViewModel> PowerSupplyViewModels { get; set; }
        public IEnumerable<GpuViewModel> GpuViewModels { get; set; }
        public IEnumerable<PortViewModel> PortViewModels { get; set; }
    }
}
