using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SilverBear.WebMVC.Models;
using SilverBear.WebMVC.Services;

namespace SilverBear.WebMVC.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly ILogger<ConfigurationController> _logger;
        private readonly IGenericService _genericService;

        public ConfigurationController(IGenericService genericService, ILogger<ConfigurationController> logger)
        {
            _genericService = genericService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("config/getLaptopConfigs")]
        public async Task<IActionResult> Configurations()
        {
            _logger.LogInformation("Now Loading Configurations");

            var configs = await _genericService.GetAllLaptopConfigs();

            return View(configs);
        }

        [HttpGet("configuration/edit/{id:int}")]
        public async Task<IActionResult> AddConfiguration(int? id)
        {
            // should ideally be cached(inmemory/redis)
            var rams = await _genericService.GetAllRams();
            var hardDiscs = await _genericService.GetAllHardDiscs();
            var powerSupplies = await _genericService.GetAllPowerSupplies();
            var gpus = await _genericService.GetAllGpus();
            var ports = await _genericService.GetAllPorts();

            ConfigurationViewModel config = new ConfigurationViewModel
            {
                LaptopViewModel = new LaptopViewModel
                {
                    LaptopID = id ?? 0
                }
            };

            if(id.HasValue && id != 0)
            {
                // render to edit
                config = await _genericService.GetConfiguration(id.Value);
            }


            return View("Configuration", new ConfigurationsViewModel
            {
                ConfigurationViewModel = config,
                RamViewModels = rams,
                HardDiscViewModels = hardDiscs,
                PowerSupplyViewModels = powerSupplies,
                GpuViewModels = gpus,
                PortViewModels = ports
            });
        }

        [HttpPost("configuration/edit/{id:int}")]
        public async Task<IActionResult> AddConfiguration(int? id, ConfigurationViewModel configurationViewModel)
        {
            if (ModelState.IsValid && id.HasValue)
            {
                try
                {
                    if(id == 0)
                    {
                        var added = await _genericService.AddConfiguration(configurationViewModel);
                        _logger.LogInformation($"add status: {added}");
                        return RedirectToAction("Configurations", "Configuration");
                    }
                    else
                    {
                        var updated = await _genericService.UpdateConfiguration(configurationViewModel);
                        _logger.LogInformation($"update status: {updated}");
                        return RedirectToAction("Configurations", "Configuration");
                    }
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("error", ex.Message);
                }
            }

            var rams = await _genericService.GetAllRams();
            var hardDiscs = await _genericService.GetAllHardDiscs();
            var powerSupplies = await _genericService.GetAllPowerSupplies();
            var gpus = await _genericService.GetAllGpus();
            var ports = await _genericService.GetAllPorts();

            return View("Configuration", new ConfigurationsViewModel
            {
                ConfigurationViewModel = configurationViewModel,
                RamViewModels = rams,
                HardDiscViewModels = hardDiscs,
                PowerSupplyViewModels = powerSupplies,
                GpuViewModels = gpus,
                PortViewModels = ports
            });
        }
    }
}