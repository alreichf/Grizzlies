using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverBear.WebMVC.Migrations
{
    public partial class initialCreate_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpus_Gpu_GpuID",
                table: "LaptopGpus");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPorts_Port_PortID",
                table: "LaptopPorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Port",
                table: "Port");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gpu",
                table: "Gpu");

            migrationBuilder.RenameTable(
                name: "Port",
                newName: "Ports");

            migrationBuilder.RenameTable(
                name: "Gpu",
                newName: "Gpus");

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Laptops",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ports",
                table: "Ports",
                column: "PortID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gpus",
                table: "Gpus",
                column: "GpuID");

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 1,
                column: "Weight",
                value: "2.2 kgs");

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 2,
                column: "Weight",
                value: "1.8 kgs");

            migrationBuilder.UpdateData(
                table: "Laptops",
                keyColumn: "LaptopID",
                keyValue: 3,
                column: "Weight",
                value: "3 kgs");

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpus_Gpus_GpuID",
                table: "LaptopGpus",
                column: "GpuID",
                principalTable: "Gpus",
                principalColumn: "GpuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPorts_Ports_PortID",
                table: "LaptopPorts",
                column: "PortID",
                principalTable: "Ports",
                principalColumn: "PortID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpus_Gpus_GpuID",
                table: "LaptopGpus");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPorts_Ports_PortID",
                table: "LaptopPorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ports",
                table: "Ports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gpus",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Laptops");

            migrationBuilder.RenameTable(
                name: "Ports",
                newName: "Port");

            migrationBuilder.RenameTable(
                name: "Gpus",
                newName: "Gpu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Port",
                table: "Port",
                column: "PortID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gpu",
                table: "Gpu",
                column: "GpuID");

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpus_Gpu_GpuID",
                table: "LaptopGpus",
                column: "GpuID",
                principalTable: "Gpu",
                principalColumn: "GpuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPorts_Port_PortID",
                table: "LaptopPorts",
                column: "PortID",
                principalTable: "Port",
                principalColumn: "PortID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
