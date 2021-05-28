
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using SilverBear.WebMVC.Dtos;
using SilverBear.WebMVC.Entities;
using SilverBear.WebMVC.Models;
using SilverBear.WebMVC.Repositories;
using SilverBear.WebMVC.Services;
using Xunit;

namespace SilverBear.Tests.Unit.Services
{
    public class GenericServiceTests
    {
        private readonly IGenericService _genericService;
        private readonly Mock<IGenericRepository> _mockGenericRepository;
        private readonly Mock<IMapper> _mockMapper;
        public GenericServiceTests()
        {
            _mockGenericRepository = new Mock<IGenericRepository>();
            _mockMapper = new Mock<IMapper>();
            _genericService = new GenericService(_mockGenericRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task ShouldGetAllLaptopConfigurations()
        {
            // Given
            var configs = new List<Configuration>()
            {
                new Configuration
                {
                    Laptop = new Laptop
                    {

                    },
                    Ram = new Ram
                    {

                    },
                    HardDisk = new HardDisk
                    {

                    },
                    PowerSupply = new PowerSupply
                    {

                    },
                    Gpu = new Gpu
                    {

                    },
                    Port = new Port
                    {

                    }
                }
            };

            var configViewModels = new List<ConfigurationViewModel>()
            {
                new ConfigurationViewModel
                {
                    LaptopViewModel = new LaptopViewModel
                    {

                    },
                    RamViewModel = new RamViewModel
                    {

                    },
                    HardDiskViewModel = new HardDiskViewModel
                    {

                    },
                    PowerSupplyViewModel = new PowerSupplyViewModel
                    {

                    },
                    GpuViewModel = new GpuViewModel
                    {

                    },
                    PortViewModel = new PortViewModel
                    {

                    }
                }
            };

            _mockGenericRepository.Setup(x => x.GetAllLaptopConfigs()).ReturnsAsync(configs);
            _mockMapper.Setup(x => x.Map<IEnumerable<ConfigurationViewModel>>(It.IsAny<IEnumerable<Configuration>>())).Returns(configViewModels);

            // When
            var obtained = await _genericService.GetAllLaptopConfigs();

            // Then
            Assert.NotNull(obtained);
            _mockGenericRepository.Verify(x => x.GetAllLaptopConfigs(), Times.Once);
            _mockMapper.Verify(x => x.Map<IEnumerable<ConfigurationViewModel>>(It.IsAny<IEnumerable<Configuration>>()), Times.Once);
        }
    }
}
