
using AutoMapper;
using SilverBear.WebMVC.Dtos;
using SilverBear.WebMVC.Entities;
using SilverBear.WebMVC.Models;

namespace SilverBear.WebMVC.Mappers
{
    public class Profiles : Profile
    {

        public Profiles()
        {
            CreateMap<Configuration, ConfigurationViewModel>()
                .ForMember(cvm => cvm.LaptopViewModel, o => o.MapFrom(c => c.Laptop))
                .ForMember(cvm => cvm.RamViewModel, o => o.MapFrom(c => c.Ram))
                .ForMember(cvm => cvm.HardDiskViewModel, o => o.MapFrom(c => c.HardDisk))
                .ForMember(cvm => cvm.PowerSupplyViewModel, o => o.MapFrom(c => c.PowerSupply))
                .ForMember(cvm => cvm.GpuViewModel, o => o.MapFrom(c => c.Gpu))
                .ForMember(cvm => cvm.PortViewModel, o => o.MapFrom(c => c.Port))
                .ReverseMap();

            CreateMap<Laptop, LaptopViewModel>()
                .ReverseMap();

            CreateMap<Ram, RamViewModel>()
                .ReverseMap();

            CreateMap<HardDisk, HardDiskViewModel>()
                .ReverseMap();

            CreateMap<PowerSupply, PowerSupplyViewModel>()
                .ReverseMap();

            CreateMap<Gpu, GpuViewModel>()
                .ReverseMap();
            
            CreateMap<Port, PortViewModel>()
                .ReverseMap();
        }
    }
}
