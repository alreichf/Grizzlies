
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverBear.WebMVC.Dtos;
using SilverBear.WebMVC.Entities;

namespace SilverBear.WebMVC.Repositories
{
    public interface IGenericRepository
    {
        Task<IEnumerable<Configuration>> GetAllLaptopConfigs();
        Task<IEnumerable<Laptop>> GetAllLaptops();
        Task<IEnumerable<Ram>> GetAllRams();
        Task<IEnumerable<HardDisk>> GetAllHardDiscs();
        Task<IEnumerable<PowerSupply>> GetAllPowerSupplies();
        Task<IEnumerable<Gpu>> GetAllGpus();
        Task<IEnumerable<Port>> GetAllPorts();
        Task<bool> AddConfiguration(Configuration configuration);
        Task<int?> AddLaptop(Laptop laptop);
        Task<bool> UpdateConfiguration(Configuration configuration);
        Task<Configuration> GetConfiguration(int id);
    }
}
