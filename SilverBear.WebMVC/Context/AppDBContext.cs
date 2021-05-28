
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SilverBear.WebMVC.Entities;

namespace SilverBear.WebMVC.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<HardDisk> HardDisks { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<LaptopHardDisk> LaptopHardDiscs { get; set; }
        public DbSet<LaptopPowerSupply> LaptopPowerSupplies { get; set; }
        public DbSet<LaptopRam> LaptopRams { get; set; }
        public DbSet<LaptopGpu> LaptopGpus { get; set; }
        public DbSet<LaptopPort> LaptopPorts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // build the model
            // m-m relationship

            modelBuilder.Entity<LaptopRam>()
                .HasKey(lr => new { lr.LaptopID, lr.RamID });

            modelBuilder.Entity<LaptopRam>()
                .HasOne(lr => lr.Laptop)
                .WithMany(l => l.LaptopRams)
                .HasForeignKey(lr => lr.LaptopID);

            modelBuilder.Entity<LaptopRam>()
                .HasOne(lr => lr.Ram)
                .WithMany(r => r.LaptopRams)
                .HasForeignKey(lr => lr.RamID);

            // m-m relationship
            modelBuilder.Entity<LaptopHardDisk>()
                .HasKey(lh => new { lh.LaptopID, lh.HardDiscID });

            modelBuilder.Entity<LaptopHardDisk>()
                .HasOne(lh => lh.Laptop)
                .WithMany(l => l.LaptopHardDiscs)
                .HasForeignKey(lh => lh.LaptopID);

            modelBuilder.Entity<LaptopHardDisk>()
                .HasOne(lh => lh.HardDisk)
                .WithMany(h => h.LaptopHardDiscs)
                .HasForeignKey(lh => lh.HardDiscID);

            // m-m relationship
            modelBuilder.Entity<LaptopPowerSupply>()
                .HasKey(lp => new { lp.LaptopID, lp.PowerSupplyID });

            modelBuilder.Entity<LaptopPowerSupply>()
                .HasOne(lp => lp.Laptop)
                .WithMany(l => l.LaptopPowerSupplies)
                .HasForeignKey(lp => lp.LaptopID);

            modelBuilder.Entity<LaptopPowerSupply>()
                .HasOne(lp => lp.PowerSupply)
                .WithMany(p => p.LaptopPowerSupplies)
                .HasForeignKey(lp => lp.PowerSupplyID);

            // m-m relationship
            modelBuilder.Entity<LaptopGpu>()
                .HasKey(lg => new { lg.LaptopID, lg.GpuID });

            modelBuilder.Entity<LaptopGpu>()
                .HasOne(lg => lg.Laptop)
                .WithMany(g => g.LaptopGpus)
                .HasForeignKey(lg => lg.LaptopID);

            modelBuilder.Entity<LaptopGpu>()
                .HasOne(lg => lg.Gpu)
                .WithMany(g => g.LaptopGpus)
                .HasForeignKey(lg => lg.GpuID);

            // m-m relationship
            modelBuilder.Entity<LaptopPort>()
                .HasKey(lp => new { lp.LaptopID, lp.PortID });

            modelBuilder.Entity<LaptopPort>()
                .HasOne(lp => lp.Laptop)
                .WithMany(g => g.LaptopPorts)
                .HasForeignKey(lp => lp.LaptopID);

            modelBuilder.Entity<LaptopPort>()
                .HasOne(lp => lp.Port)
                .WithMany(p => p.LaptopPorts)
                .HasForeignKey(lp => lp.PortID);

            // populate Data

            var rams = new List<Ram>
            {
                new Ram
                {
                    RamID = 1,
                    Name = "512 MB",
                    Make = "Intel® Core™ i5-6400 Processor"
                },
                new Ram
                {
                    RamID = 2,
                    Name = "2 GB",
                    Make = "Intel Core i7 Extreme Edition 3 GHz Processor"
                },
                new Ram
                {
                    RamID = 3,
                    Name = "8 GB",
                    Make = "Intel® Celeron™ N3050 Processor"
                },
                new Ram
                {
                    RamID = 4,
                    Name = "16 GB",
                    Make = "AMD FX 4300 Processor"
                },
                new Ram
                {
                    RamID = 5,
                    Name = "32 GB",
                    Make = "AMD FX 8-Core Black Edition FX-8370 "
                },
            };

            modelBuilder.Entity<Ram>()
                .HasData(rams);

            var hardDisks = new List<HardDisk>
            {
                new HardDisk
                {
                    HardDiskID = 1,
                    Size = "1 TB",
                    Type = "SSD"
                },
                new HardDisk
                {
                    HardDiskID = 2,
                    Size = "2 TB",
                    Type = "HDD"
                },
                new HardDisk
                {
                    HardDiskID = 3,
                    Size = "3 TB",
                    Type = "HDD"
                },
                new HardDisk
                {
                    HardDiskID = 4,
                    Size = "4 TB",
                    Type = "HDD"
                },
                new HardDisk
                {
                    HardDiskID = 5,
                    Size = "750 GB",
                    Type = "SSD"
                },
                new HardDisk
                {
                    HardDiskID = 6,
                    Size = "2 TB",
                    Type = "SSD"
                },
                new HardDisk
                {
                    HardDiskID = 7,
                    Size = "500 GB",
                    Type = "SSD"
                },
            };

            modelBuilder.Entity<HardDisk>()
                .HasData(hardDisks);

            var powerSupplies = new List<PowerSupply>
            {
                new PowerSupply
                {
                    PowerSupplyID = 1,
                    Name = "500 W PSU"
                },
                new PowerSupply
                {
                    PowerSupplyID = 2,
                    Name = "450 W PSU"
                },
                new PowerSupply
                {
                    PowerSupplyID = 3,
                    Name = "1000 W PSU"
                },
                new PowerSupply
                {
                    PowerSupplyID = 4,
                    Name = "750 W PSU"
                },
                new PowerSupply
                {
                    PowerSupplyID = 5,
                    Name = "700 W PSU"
                },
            };

            modelBuilder.Entity<PowerSupply>()
                .HasData(powerSupplies);

            var gpus = new List<Gpu>
            {
                new Gpu
                {
                    GpuID = 1,
                    Name = "NVIDIA GeForce GTX 770"
                },
                new Gpu
                {
                    GpuID = 2,
                    Name = "NVIDIA GeForce GTX 960"
                },
                new Gpu
                {
                    GpuID = 3,
                    Name = "Radeon R7360"
                },
                new Gpu
                {
                    GpuID = 4,
                    Name = "NVIDIA GeForce GTX 1080"
                },
                new Gpu
                {
                    GpuID = 5,
                    Name = "Radeon RX 480"
                },
                new Gpu
                {
                    GpuID = 6,
                    Name = "Radeon R9 380"
                },
                new Gpu
                {
                    GpuID = 7,
                    Name = "NVIDIA GeForce GTX 1080"
                }
            };

            modelBuilder.Entity<Gpu>()
                .HasData(gpus);

            var ports = new List<Port>
            {
                new Port
                {
                    PortID = 1,
                    Name = "USB 2.0"
                },
                new Port
                {
                    PortID = 2,
                    Name = "USB 3.0"
                },
                new Port
                {
                    PortID = 3,
                    Name = "USB C"
                }
            };

            modelBuilder.Entity<Port>()
                .HasData(ports);

            modelBuilder.Entity<Laptop>(
                l => l.HasData(
                    new
                    {
                        LaptopID = 1,
                        Name = "Laptop1",
                        Weight = "2.2 kgs"
                    },
                    new
                    {
                        LaptopID = 2,
                        Name = "Laptop2",
                        Weight = "1.8 kgs"
                    },
                    new
                    {
                        LaptopID = 3,
                        Name = "Laptop3",
                        Weight = "3 kgs"
                    }
                )
            );

            modelBuilder.Entity<LaptopRam>(
              lr => lr.HasData(
                new
                {
                    LaptopID = 1,
                    RamID = 1,
                },
                new
                {
                    LaptopID = 2,
                    RamID = 3,
                }
              )
            );

            modelBuilder.Entity<LaptopGpu>(
              lg => lg.HasData(
                new
                {
                    LaptopID = 1,
                    GpuID = 1,
                },
                new
                {
                    LaptopID = 2,
                    GpuID = 2,
                }
              )
            );

            modelBuilder.Entity<LaptopHardDisk>(
              lg => lg.HasData(
                new
                {
                    LaptopID = 1,
                    HardDiscID = 1,
                },
                new
                {
                    LaptopID = 2,
                    HardDiscID = 3,
                }
              )
            );

            modelBuilder.Entity<LaptopPort>(
              lg => lg.HasData(
                new
                {
                    LaptopID = 1,
                    PortID = 1,
                },
                new
                {
                    LaptopID = 2,
                    PortID = 2,
                }
              )
            );

            modelBuilder.Entity<LaptopPowerSupply>(
              lg => lg.HasData(
                new
                {
                    LaptopID = 1,
                    PowerSupplyID = 1,
                },
                new
                {
                    LaptopID = 2,
                    PowerSupplyID = 4,
                }
              )
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseNpgsql(
                    "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=silverbearDB",
                    b => b.MigrationsAssembly("SilverBear.WebMVC")
                );
            }
        }
    }
}
