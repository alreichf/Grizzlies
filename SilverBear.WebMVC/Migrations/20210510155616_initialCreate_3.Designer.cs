﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SilverBear.WebMVC.Context;

namespace SilverBear.WebMVC.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210510155616_initialCreate_3")]
    partial class initialCreate_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Gpu", b =>
                {
                    b.Property<int>("GpuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("GpuID");

                    b.ToTable("Gpus");

                    b.HasData(
                        new
                        {
                            GpuID = 1,
                            Name = "NVIDIA GeForce GTX 770"
                        },
                        new
                        {
                            GpuID = 2,
                            Name = "NVIDIA GeForce GTX 960"
                        },
                        new
                        {
                            GpuID = 3,
                            Name = "Radeon R7360"
                        },
                        new
                        {
                            GpuID = 4,
                            Name = "NVIDIA GeForce GTX 1080"
                        },
                        new
                        {
                            GpuID = 5,
                            Name = "Radeon RX 480"
                        },
                        new
                        {
                            GpuID = 6,
                            Name = "Radeon R9 380"
                        },
                        new
                        {
                            GpuID = 7,
                            Name = "NVIDIA GeForce GTX 1080"
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.HardDisk", b =>
                {
                    b.Property<int>("HardDiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("HardDiskID");

                    b.ToTable("HardDisks");

                    b.HasData(
                        new
                        {
                            HardDiskID = 1,
                            Size = "1 TB",
                            Type = "SSD"
                        },
                        new
                        {
                            HardDiskID = 2,
                            Size = "2 TB",
                            Type = "HDD"
                        },
                        new
                        {
                            HardDiskID = 3,
                            Size = "3 TB",
                            Type = "HDD"
                        },
                        new
                        {
                            HardDiskID = 4,
                            Size = "4 TB",
                            Type = "HDD"
                        },
                        new
                        {
                            HardDiskID = 5,
                            Size = "750 GB",
                            Type = "SSD"
                        },
                        new
                        {
                            HardDiskID = 6,
                            Size = "2 TB",
                            Type = "SSD"
                        },
                        new
                        {
                            HardDiskID = 7,
                            Size = "500 GB",
                            Type = "SSD"
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Laptop", b =>
                {
                    b.Property<int>("LaptopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("LaptopID");

                    b.ToTable("Laptops");

                    b.HasData(
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
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopGpu", b =>
                {
                    b.Property<int>("LaptopID")
                        .HasColumnType("integer");

                    b.Property<int>("GpuID")
                        .HasColumnType("integer");

                    b.HasKey("LaptopID", "GpuID");

                    b.HasIndex("GpuID");

                    b.ToTable("LaptopGpus");

                    b.HasData(
                        new
                        {
                            LaptopID = 1,
                            GpuID = 1
                        },
                        new
                        {
                            LaptopID = 2,
                            GpuID = 2
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopHardDisc", b =>
                {
                    b.Property<int?>("LaptopID")
                        .HasColumnType("integer");

                    b.Property<int?>("HardDiscID")
                        .HasColumnType("integer");

                    b.HasKey("LaptopID", "HardDiscID");

                    b.HasIndex("HardDiscID");

                    b.ToTable("LaptopHardDiscs");

                    b.HasData(
                        new
                        {
                            LaptopID = 1,
                            HardDiscID = 1
                        },
                        new
                        {
                            LaptopID = 2,
                            HardDiscID = 3
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopPort", b =>
                {
                    b.Property<int>("LaptopID")
                        .HasColumnType("integer");

                    b.Property<int>("PortID")
                        .HasColumnType("integer");

                    b.HasKey("LaptopID", "PortID");

                    b.HasIndex("PortID");

                    b.ToTable("LaptopPorts");

                    b.HasData(
                        new
                        {
                            LaptopID = 1,
                            PortID = 1
                        },
                        new
                        {
                            LaptopID = 2,
                            PortID = 2
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopPowerSupply", b =>
                {
                    b.Property<int?>("LaptopID")
                        .HasColumnType("integer");

                    b.Property<int?>("PowerSupplyID")
                        .HasColumnType("integer");

                    b.HasKey("LaptopID", "PowerSupplyID");

                    b.HasIndex("PowerSupplyID");

                    b.ToTable("LaptopPowerSupplies");

                    b.HasData(
                        new
                        {
                            LaptopID = 1,
                            PowerSupplyID = 1
                        },
                        new
                        {
                            LaptopID = 2,
                            PowerSupplyID = 4
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopRam", b =>
                {
                    b.Property<int?>("LaptopID")
                        .HasColumnType("integer");

                    b.Property<int?>("RamID")
                        .HasColumnType("integer");

                    b.HasKey("LaptopID", "RamID");

                    b.HasIndex("RamID");

                    b.ToTable("LaptopRams");

                    b.HasData(
                        new
                        {
                            LaptopID = 1,
                            RamID = 1
                        },
                        new
                        {
                            LaptopID = 2,
                            RamID = 3
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Port", b =>
                {
                    b.Property<int>("PortID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("PortID");

                    b.ToTable("Ports");

                    b.HasData(
                        new
                        {
                            PortID = 1,
                            Name = "USB 2.0"
                        },
                        new
                        {
                            PortID = 2,
                            Name = "USB 3.0"
                        },
                        new
                        {
                            PortID = 3,
                            Name = "USB C"
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.PowerSupply", b =>
                {
                    b.Property<int>("PowerSupplyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("PowerSupplyID");

                    b.ToTable("PowerSupplies");

                    b.HasData(
                        new
                        {
                            PowerSupplyID = 1,
                            Name = "500 W PSU"
                        },
                        new
                        {
                            PowerSupplyID = 2,
                            Name = "450 W PSU"
                        },
                        new
                        {
                            PowerSupplyID = 3,
                            Name = "1000 W PSU"
                        },
                        new
                        {
                            PowerSupplyID = 4,
                            Name = "750 W PSU"
                        },
                        new
                        {
                            PowerSupplyID = 5,
                            Name = "700 W PSU"
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Ram", b =>
                {
                    b.Property<int>("RamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Make")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("RamID");

                    b.ToTable("Rams");

                    b.HasData(
                        new
                        {
                            RamID = 1,
                            Make = "Intel® Core™ i5-6400 Processor",
                            Name = "512 MB"
                        },
                        new
                        {
                            RamID = 2,
                            Make = "Intel Core i7 Extreme Edition 3 GHz Processor",
                            Name = "2 GB"
                        },
                        new
                        {
                            RamID = 3,
                            Make = "Intel® Celeron™ N3050 Processor",
                            Name = "8 GB"
                        },
                        new
                        {
                            RamID = 4,
                            Make = "AMD FX 4300 Processor",
                            Name = "16 GB"
                        },
                        new
                        {
                            RamID = 5,
                            Make = "AMD FX 8-Core Black Edition FX-8370 ",
                            Name = "32 GB"
                        });
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopGpu", b =>
                {
                    b.HasOne("SilverBear.WebMVC.Entities.Gpu", "Gpu")
                        .WithMany("LaptopGpus")
                        .HasForeignKey("GpuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SilverBear.WebMVC.Entities.Laptop", "Laptop")
                        .WithMany("LaptopGpus")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gpu");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopHardDisc", b =>
                {
                    b.HasOne("SilverBear.WebMVC.Entities.HardDisk", "HardDisk")
                        .WithMany("LaptopHardDiscs")
                        .HasForeignKey("HardDiscID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SilverBear.WebMVC.Entities.Laptop", "Laptop")
                        .WithMany("LaptopHardDiscs")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HardDisk");

                    b.Navigation("Laptop");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopPort", b =>
                {
                    b.HasOne("SilverBear.WebMVC.Entities.Laptop", "Laptop")
                        .WithMany("LaptopPorts")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SilverBear.WebMVC.Entities.Port", "Port")
                        .WithMany("LaptopPorts")
                        .HasForeignKey("PortID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laptop");

                    b.Navigation("Port");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopPowerSupply", b =>
                {
                    b.HasOne("SilverBear.WebMVC.Entities.Laptop", "Laptop")
                        .WithMany("LaptopPowerSupplies")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SilverBear.WebMVC.Entities.PowerSupply", "PowerSupply")
                        .WithMany("LaptopPowerSupplies")
                        .HasForeignKey("PowerSupplyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laptop");

                    b.Navigation("PowerSupply");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.LaptopRam", b =>
                {
                    b.HasOne("SilverBear.WebMVC.Entities.Laptop", "Laptop")
                        .WithMany("LaptopRams")
                        .HasForeignKey("LaptopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SilverBear.WebMVC.Entities.Ram", "Ram")
                        .WithMany("LaptopRams")
                        .HasForeignKey("RamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laptop");

                    b.Navigation("Ram");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Gpu", b =>
                {
                    b.Navigation("LaptopGpus");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.HardDisk", b =>
                {
                    b.Navigation("LaptopHardDiscs");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Laptop", b =>
                {
                    b.Navigation("LaptopGpus");

                    b.Navigation("LaptopHardDiscs");

                    b.Navigation("LaptopPorts");

                    b.Navigation("LaptopPowerSupplies");

                    b.Navigation("LaptopRams");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Port", b =>
                {
                    b.Navigation("LaptopPorts");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.PowerSupply", b =>
                {
                    b.Navigation("LaptopPowerSupplies");
                });

            modelBuilder.Entity("SilverBear.WebMVC.Entities.Ram", b =>
                {
                    b.Navigation("LaptopRams");
                });
#pragma warning restore 612, 618
        }
    }
}
