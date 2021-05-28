using System.Collections.Generic;
using System.Threading.Tasks;
using SilverBear.WebMVC.Models;

namespace SilverBear.WebMVC.Services
{
    public interface IGenericService
    {
        Task<IEnumerable<LaptopViewModel>> GetAllLaptops();
        Task<IEnumerable<RamViewModel>> GetAllRams();
        Task<IEnumerable<HardDiskViewModel>> GetAllHardDiscs();
        Task<IEnumerable<PowerSupplyViewModel>> GetAllPowerSupplies();
        Task<IEnumerable<GpuViewModel>> GetAllGpus();
        Task<IEnumerable<PortViewModel>> GetAllPorts();
        Task<IEnumerable<ConfigurationViewModel>> GetAllLaptopConfigs();
        Task<bool> AddConfiguration(ConfigurationViewModel configurationViewModel);
        Task<bool> UpdateConfiguration(ConfigurationViewModel configurationViewModel);
        Task<ConfigurationViewModel> GetConfiguration(int id);
    }
}
