using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverBear.WebMVC.Migrations
{
    public partial class initialCreate_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LaptopGpus",
                columns: new[] { "GpuID", "LaptopID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "LaptopHardDiscs",
                columns: new[] { "HardDiscID", "LaptopID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "LaptopPorts",
                columns: new[] { "LaptopID", "PortID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "LaptopPowerSupplies",
                columns: new[] { "LaptopID", "PowerSupplyID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "LaptopRams",
                columns: new[] { "LaptopID", "RamID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 1,
                column: "Name",
                value: "Laptop1");

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 2,
                column: "Name",
                value: "Laptop2");

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 3,
                column: "Name",
                value: "Laptop3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LaptopGpus",
                keyColumns: new[] { "GpuID", "LaptopID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LaptopGpus",
                keyColumns: new[] { "GpuID", "LaptopID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LaptopHardDiscs",
                keyColumns: new[] { "HardDiscID", "LaptopID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LaptopHardDiscs",
                keyColumns: new[] { "HardDiscID", "LaptopID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "LaptopPorts",
                keyColumns: new[] { "LaptopID", "PortID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LaptopPorts",
                keyColumns: new[] { "LaptopID", "PortID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LaptopPowerSupplies",
                keyColumns: new[] { "LaptopID", "PowerSupplyID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LaptopPowerSupplies",
                keyColumns: new[] { "LaptopID", "PowerSupplyID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "LaptopRams",
                keyColumns: new[] { "LaptopID", "RamID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LaptopRams",
                keyColumns: new[] { "LaptopID", "RamID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 1,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 2,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 3,
                column: "Name",
                value: null);
        }
    }
}
