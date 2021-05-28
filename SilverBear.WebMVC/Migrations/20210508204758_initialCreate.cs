using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SilverBear.WebMVC.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {
                    GpuID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpu", x => x.GpuID);
                });

            migrationBuilder.CreateTable(
                name: "HardDisks",
                columns: table => new
                {
                    HardDiskID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDisks", x => x.HardDiskID);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.LaptopID);
                });

            migrationBuilder.CreateTable(
                name: "Port",
                columns: table => new
                {
                    PortID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.PortID);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    PowerSupplyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.PowerSupplyID);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    RamID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Make = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.RamID);
                });

            migrationBuilder.CreateTable(
                name: "LaptopGpu",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false),
                    GpuID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopGpu", x => new { x.LaptopID, x.GpuID });
                    table.ForeignKey(
                        name: "FK_LaptopGpu_Gpu_GpuID",
                        column: x => x.GpuID,
                        principalTable: "Gpu",
                        principalColumn: "GpuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopGpu_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaptopHardDiscs",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false),
                    HardDiscID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopHardDiscs", x => new { x.LaptopID, x.HardDiscID });
                    table.ForeignKey(
                        name: "FK_LaptopHardDiscs_HardDisks_HardDiscID",
                        column: x => x.HardDiscID,
                        principalTable: "HardDisks",
                        principalColumn: "HardDiskID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopHardDiscs_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaptopPort",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false),
                    PortID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopPort", x => new { x.LaptopID, x.PortID });
                    table.ForeignKey(
                        name: "FK_LaptopPort_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopPort_Port_PortID",
                        column: x => x.PortID,
                        principalTable: "Port",
                        principalColumn: "PortID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaptopPowerSupplies",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false),
                    PowerSupplyID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopPowerSupplies", x => new { x.LaptopID, x.PowerSupplyID });
                    table.ForeignKey(
                        name: "FK_LaptopPowerSupplies_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopPowerSupplies_PowerSupplies_PowerSupplyID",
                        column: x => x.PowerSupplyID,
                        principalTable: "PowerSupplies",
                        principalColumn: "PowerSupplyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaptopRams",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "integer", nullable: false),
                    RamID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopRams", x => new { x.LaptopID, x.RamID });
                    table.ForeignKey(
                        name: "FK_LaptopRams_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopRams_Rams_RamID",
                        column: x => x.RamID,
                        principalTable: "Rams",
                        principalColumn: "RamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gpu",
                columns: new[] { "GpuID", "Name" },
                values: new object[,]
                {
                    { 1, "NVIDIA GeForce GTX 770" },
                    { 2, "NVIDIA GeForce GTX 960" },
                    { 3, "Radeon R7360" },
                    { 4, "NVIDIA GeForce GTX 1080" },
                    { 5, "Radeon RX 480" },
                    { 6, "Radeon R9 380" },
                    { 7, "NVIDIA GeForce GTX 1080" }
                });

            migrationBuilder.InsertData(
                table: "HardDisks",
                columns: new[] { "HardDiskID", "Size", "Type" },
                values: new object[,]
                {
                    { 1, "1 TB", "SSD" },
                    { 2, "2 TB", "HDD" },
                    { 3, "3 TB", "HDD" },
                    { 4, "4 TB", "HDD" },
                    { 5, "750 GB", "SSD" },
                    { 6, "2 TB", "SSD" },
                    { 7, "500 GB", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "LaptopID", "Name" },
                values: new object[,]
                {
                    { 3, null },
                    { 1, null },
                    { 2, null }
                });

            migrationBuilder.InsertData(
                table: "Port",
                columns: new[] { "PortID", "Name" },
                values: new object[,]
                {
                    { 1, "USB 2.0" },
                    { 2, "USB 3.0" },
                    { 3, "USB C" }
                });

            migrationBuilder.InsertData(
                table: "PowerSupplies",
                columns: new[] { "PowerSupplyID", "Name" },
                values: new object[,]
                {
                    { 1, "500 W PSU" },
                    { 2, "450 W PSU" },
                    { 3, "1000 W PSU" },
                    { 4, "750 W PSU" },
                    { 5, "700 W PSU" }
                });

            migrationBuilder.InsertData(
                table: "Rams",
                columns: new[] { "RamID", "Make", "Name" },
                values: new object[,]
                {
                    { 4, "AMD FX 4300 Processor", "16 GB" },
                    { 1, "Intel® Core™ i5-6400 Processor", "512 MB" },
                    { 2, "Intel Core i7 Extreme Edition 3 GHz Processor", "2 GB" },
                    { 3, "Intel® Celeron™ N3050 Processor", "8 GB" },
                    { 5, "AMD FX 8-Core Black Edition FX-8370 ", "32 GB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LaptopGpu_GpuID",
                table: "LaptopGpu",
                column: "GpuID");

            migrationBuilder.CreateIndex(
                name: "IX_LaptopHardDiscs_HardDiscID",
                table: "LaptopHardDiscs",
                column: "HardDiscID");

            migrationBuilder.CreateIndex(
                name: "IX_LaptopPort_PortID",
                table: "LaptopPort",
                column: "PortID");

            migrationBuilder.CreateIndex(
                name: "IX_LaptopPowerSupplies_PowerSupplyID",
                table: "LaptopPowerSupplies",
                column: "PowerSupplyID");

            migrationBuilder.CreateIndex(
                name: "IX_LaptopRams_RamID",
                table: "LaptopRams",
                column: "RamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaptopGpu");

            migrationBuilder.DropTable(
                name: "LaptopHardDiscs");

            migrationBuilder.DropTable(
                name: "LaptopPort");

            migrationBuilder.DropTable(
                name: "LaptopPowerSupplies");

            migrationBuilder.DropTable(
                name: "LaptopRams");

            migrationBuilder.DropTable(
                name: "Gpu");

            migrationBuilder.DropTable(
                name: "HardDisks");

            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
