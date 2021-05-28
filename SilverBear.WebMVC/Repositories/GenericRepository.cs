
using System;
using System.Threading.Tasks;
using SilverBear.WebMVC.Context;
using SilverBear.WebMVC.Entities;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SilverBear.WebMVC.Dtos;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using SilverBear.WebMVC.Exceptions;

namespace SilverBear.WebMVC.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly AppDBContext _appDBContext;

        public GenericRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<IEnumerable<Gpu>> GetAllGpus()
        {
            return await _appDBContext.Gpus.ToListAsync();
        }

        public async Task<IEnumerable<HardDisk>> GetAllHardDiscs()
        {
            return await _appDBContext.HardDisks.ToListAsync();

        }

        public async Task<IEnumerable<Configuration>> GetAllLaptopConfigs()
        {
            // left join
            var foo = (from l in _appDBContext.Laptops
                       join lr in _appDBContext.LaptopRams on l.LaptopID equals lr.LaptopID into lrls
                       from lr in lrls.DefaultIfEmpty()
                       select new
                       {
                           LaptopId = lr.LaptopID,
                           RamId = lr.RamID
                       }).ToListAsync();



            var configs = await (from l in _appDBContext.Laptops
                           join lr in _appDBContext.LaptopRams on l.LaptopID equals lr.LaptopID
                           join r in _appDBContext.Rams on lr.RamID equals r.RamID
                           join lh in _appDBContext.LaptopHardDiscs on l.LaptopID equals lh.LaptopID
                           join h in _appDBContext.HardDisks on lh.HardDiscID equals h.HardDiskID
                           join lps in _appDBContext.LaptopPowerSupplies on l.LaptopID equals lps.LaptopID
                           join ps in _appDBContext.PowerSupplies on lps.PowerSupplyID equals ps.PowerSupplyID
                           join lg in _appDBContext.LaptopGpus on l.LaptopID equals lg.LaptopID
                           join g in _appDBContext.Gpus on lg.GpuID equals g.GpuID
                           join lp in _appDBContext.LaptopPorts on l.LaptopID equals lp.LaptopID
                           join p in _appDBContext.Ports on lp.PortID equals p.PortID
                           select new Configuration
                           {
                               Laptop = new Laptop
                               {
                                   LaptopID = l.LaptopID,
                                   Name = l.Name,
                                   Weight = l.Weight
                               },
                               Ram = new Ram
                               {
                                   RamID = r.RamID,
                                   Name = r.Name,
                                   Make = r.Make
                               },
                               HardDisk = new HardDisk
                               {
                                   HardDiskID = h.HardDiskID,
                                   Size = h.Size,
                                   Type = h.Type
                               },
                               PowerSupply = new PowerSupply
                               {
                                   PowerSupplyID = ps.PowerSupplyID,
                                   Name = ps.Name
                               },
                               Gpu = new Gpu
                               {
                                   GpuID = g.GpuID,
                                   Name = g.Name
                               },
                               Port = new Port
                               {
                                   PortID = p.PortID,
                                   Name = p.Name
                               }
                           }).ToListAsync();

            return configs;
        }

        public async Task<IEnumerable<Laptop>> GetAllLaptops()
        {
            return await _appDBContext.Laptops.ToListAsync();
        }

        public async Task<IEnumerable<Port>> GetAllPorts()
        {
            return await _appDBContext.Ports.ToListAsync();
        }

        public async Task<IEnumerable<PowerSupply>> GetAllPowerSupplies()
        {
            return await _appDBContext.PowerSupplies.ToListAsync();
        }

        public async Task<IEnumerable<Ram>> GetAllRams()
        {
            return await _appDBContext.Rams.ToListAsync();
        }

        public async Task<bool> AddConfiguration(Configuration configuration)
        {
            await _appDBContext.LaptopRams.AddAsync(new LaptopRam { LaptopID = configuration.Laptop.LaptopID, RamID = configuration.Ram.RamID});
            await _appDBContext.LaptopHardDiscs.AddAsync(new LaptopHardDisk { LaptopID = configuration.Laptop.LaptopID, HardDiscID = configuration.HardDisk.HardDiskID});
            await _appDBContext.LaptopPowerSupplies.AddAsync(new LaptopPowerSupply { LaptopID = configuration.Laptop.LaptopID, PowerSupplyID = configuration.PowerSupply.PowerSupplyID});
            await _appDBContext.LaptopGpus.AddAsync(new LaptopGpu { LaptopID = configuration.Laptop.LaptopID, GpuID = configuration.Gpu.GpuID});
            await _appDBContext.LaptopPorts.AddAsync(new LaptopPort { LaptopID = configuration.Laptop.LaptopID, PortID = configuration.Port.PortID});
            return await _appDBContext.SaveChangesAsync() > 0;
        }

        public async Task<int?> AddLaptop(Laptop laptop)
        {
            await _appDBContext.Laptops.AddAsync(laptop);
            await _appDBContext.SaveChangesAsync();

            return laptop.LaptopID;
        }

        public async Task<Configuration> GetConfiguration(int id)
        {
            var config = await (from l in _appDBContext.Laptops
                                 join lr in _appDBContext.LaptopRams on l.LaptopID equals lr.LaptopID
                                 join r in _appDBContext.Rams on lr.RamID equals r.RamID
                                 join lh in _appDBContext.LaptopHardDiscs on l.LaptopID equals lh.LaptopID
                                 join h in _appDBContext.HardDisks on lh.HardDiscID equals h.HardDiskID
                                 join lps in _appDBContext.LaptopPowerSupplies on l.LaptopID equals lps.LaptopID
                                 join ps in _appDBContext.PowerSupplies on lps.PowerSupplyID equals ps.PowerSupplyID
                                 join lg in _appDBContext.LaptopGpus on l.LaptopID equals lg.LaptopID
                                 join g in _appDBContext.Gpus on lg.GpuID equals g.GpuID
                                 join lp in _appDBContext.LaptopPorts on l.LaptopID equals lp.LaptopID
                                 join p in _appDBContext.Ports on lp.PortID equals p.PortID
                                 where l.LaptopID.Equals(id)
                                 select new Configuration
                                 {
                                     Laptop = new Laptop
                                     {
                                         LaptopID = l.LaptopID,
                                         Name = l.Name,
                                         Weight = l.Weight
                                     },
                                     Ram = new Ram
                                     {
                                         RamID = r.RamID,
                                         Name = r.Name,
                                         Make = r.Make
                                     },
                                     HardDisk = new HardDisk
                                     {
                                         HardDiskID = h.HardDiskID,
                                         Size = h.Size,
                                         Type = h.Type
                                     },
                                     PowerSupply = new PowerSupply
                                     {
                                         PowerSupplyID = ps.PowerSupplyID,
                                         Name = ps.Name
                                     },
                                     Gpu = new Gpu
                                     {
                                         GpuID = g.GpuID,
                                         Name = g.Name
                                     },
                                     Port = new Port
                                     {
                                         PortID = p.PortID,
                                         Name = p.Name
                                     }
                                 }).FirstOrDefaultAsync();

            if(config is null)
            {
                throw new ConfigNotFoundException($"configuration for id:{id} does not exist");
            }

            return config;
        }

        public async Task<bool> UpdateConfiguration(Configuration configuration)
        {
            var config = await _appDBContext.Laptops
                .Include(l => l.LaptopRams)
                .Include(l => l.LaptopHardDiscs)
                .Include(l => l.LaptopPowerSupplies)
                .Include(l => l.LaptopGpus)
                .Include(l => l.LaptopPorts)
                .FirstOrDefaultAsync(l => l.LaptopID.Equals(configuration.Laptop.LaptopID));


            config.Weight = configuration.Laptop.Weight;
            config.LaptopHardDiscs.Clear();
            config.LaptopHardDiscs.Add(new LaptopHardDisk { LaptopID = configuration.Laptop.LaptopID, HardDiscID = configuration.HardDisk.HardDiskID });
            config.LaptopRams.Clear();
            config.LaptopRams.Add(new LaptopRam { LaptopID = configuration.Laptop.LaptopID, RamID = configuration.Ram.RamID });
            config.LaptopPowerSupplies.Clear();
            config.LaptopPowerSupplies.Add(new LaptopPowerSupply { LaptopID = configuration.Laptop.LaptopID, PowerSupplyID = configuration.PowerSupply.PowerSupplyID });
            config.LaptopGpus.Clear();
            config.LaptopGpus.Add(new LaptopGpu { LaptopID = configuration.Laptop.LaptopID, GpuID = configuration.Gpu.GpuID });
            config.LaptopPorts.Clear();
            config.LaptopPorts.Add(new LaptopPort { LaptopID = configuration.Laptop.LaptopID, PortID = configuration.Port.PortID });

            return await _appDBContext.SaveChangesAsync() > 0;
        }
    }
}
