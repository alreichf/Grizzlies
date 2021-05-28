
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SilverBear.WebMVC.Dtos;
using SilverBear.WebMVC.Models;
using SilverBear.WebMVC.Repositories;

namespace SilverBear.WebMVC.Services
{
    public class GenericService : IGenericService
    {
        private readonly IGenericRepository _genericRepository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddConfiguration(ConfigurationViewModel configurationViewModel)
        {
            var configuration = _mapper.Map<Configuration>(configurationViewModel);

            if(configuration.Laptop.LaptopID is null || configuration.Laptop.LaptopID == 0)
            {
                configuration.Laptop.LaptopID = null;
                var laptopId = await _genericRepository.AddLaptop(configuration.Laptop);
                configuration.Laptop.LaptopID = laptopId;
            }

            var added = await _genericRepository.AddConfiguration(configuration);

            return added;
        }

        public async Task<IEnumerable<GpuViewModel>> GetAllGpus()
        {
            var gpus = await _genericRepository.GetAllGpus();

            return _mapper.Map<IEnumerable<GpuViewModel>>(gpus);
        }

        public async Task<IEnumerable<HardDiskViewModel>> GetAllHardDiscs()
        {
            var discs = await _genericRepository.GetAllHardDiscs();

            return _mapper.Map<IEnumerable<HardDiskViewModel>>(discs);
        }

        public async Task<IEnumerable<ConfigurationViewModel>> GetAllLaptopConfigs()
        {
            var configs = await _genericRepository.GetAllLaptopConfigs();

            return _mapper.Map<IEnumerable<ConfigurationViewModel>>(configs);
        }

        public async Task<IEnumerable<LaptopViewModel>> GetAllLaptops()
        {
            var laptops = await _genericRepository.GetAllLaptops();

            return _mapper.Map<IEnumerable<LaptopViewModel>>(laptops);
        }

        public async Task<IEnumerable<PortViewModel>> GetAllPorts()
        {
            var ports = await _genericRepository.GetAllPorts();

            return _mapper.Map<IEnumerable<PortViewModel>>(ports);
        }

        public async Task<IEnumerable<PowerSupplyViewModel>> GetAllPowerSupplies()
        {
            var powerSupplies = await _genericRepository.GetAllPowerSupplies();

            return _mapper.Map<IEnumerable<PowerSupplyViewModel>>(powerSupplies);
        }

        public async Task<IEnumerable<RamViewModel>> GetAllRams()
        {
            var rams = await _genericRepository.GetAllRams();

            return _mapper.Map<IEnumerable<RamViewModel>>(rams);
        }

        public async Task<ConfigurationViewModel> GetConfiguration(int id)
        {
            return _mapper.Map<ConfigurationViewModel>(await _genericRepository.GetConfiguration(id));
        }

        public async Task<bool> UpdateConfiguration(ConfigurationViewModel configurationViewModel)
        {
            var existingConfiguraton = await _genericRepository.GetConfiguration(configurationViewModel.LaptopViewModel.LaptopID.Value);

            _mapper.Map(configurationViewModel, existingConfiguraton);

            var updated = await _genericRepository.UpdateConfiguration(existingConfiguraton);

            return updated;
        }
    }
}
