using FluentValidation;
using SilverBear.WebMVC.Models;

namespace SilverBear.WebMVC.Validators
{
    public class ConfigurationValidator : AbstractValidator<ConfigurationViewModel>
    {
        public ConfigurationValidator()
        {
            RuleFor(c => c)
                .Must(c => ShouldBeValid(c))
                .WithMessage("All Fields are mandatory");
        } 

        private bool ShouldBeValid(ConfigurationViewModel configurationViewModel)
        {
            return 
                (configurationViewModel.LaptopViewModel.Weight is object )
                &&
                (configurationViewModel.RamViewModel.RamID.HasValue && configurationViewModel.RamViewModel.RamID.Value > 0)
                &&
                (configurationViewModel.HardDiskViewModel.HardDiskID.HasValue && configurationViewModel.HardDiskViewModel.HardDiskID.Value > 0)
                &&
                (configurationViewModel.PowerSupplyViewModel.PowerSupplyID.HasValue && configurationViewModel.PowerSupplyViewModel.PowerSupplyID.Value > 0)
                &&
                (configurationViewModel.GpuViewModel.GpuID.HasValue && configurationViewModel.GpuViewModel.GpuID.Value > 0)
                &&
                (configurationViewModel.PortViewModel.PortID.HasValue && configurationViewModel.PortViewModel.PortID.Value > 0);
        }
    }
}
