using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverBear.WebMVC.Migrations
{
    public partial class initialCreate_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpu_Gpu_GpuID",
                table: "LaptopGpu");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpu_Laptops_LaptopID",
                table: "LaptopGpu");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPort_Laptops_LaptopID",
                table: "LaptopPort");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPort_Port_PortID",
                table: "LaptopPort");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaptopPort",
                table: "LaptopPort");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaptopGpu",
                table: "LaptopGpu");

            migrationBuilder.RenameTable(
                name: "LaptopPort",
                newName: "LaptopPorts");

            migrationBuilder.RenameTable(
                name: "LaptopGpu",
                newName: "LaptopGpus");

            migrationBuilder.RenameIndex(
                name: "IX_LaptopPort_PortID",
                table: "LaptopPorts",
                newName: "IX_LaptopPorts_PortID");

            migrationBuilder.RenameIndex(
                name: "IX_LaptopGpu_GpuID",
                table: "LaptopGpus",
                newName: "IX_LaptopGpus_GpuID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaptopPorts",
                table: "LaptopPorts",
                columns: new[] { "LaptopID", "PortID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaptopGpus",
                table: "LaptopGpus",
                columns: new[] { "LaptopID", "GpuID" });

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpus_Gpu_GpuID",
                table: "LaptopGpus",
                column: "GpuID",
                principalTable: "Gpu",
                principalColumn: "GpuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpus_Laptops_LaptopID",
                table: "LaptopGpus",
                column: "LaptopID",
                principalTable: "Laptops",
                principalColumn: "LaptopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPorts_Laptops_LaptopID",
                table: "LaptopPorts",
                column: "LaptopID",
                principalTable: "Laptops",
                principalColumn: "LaptopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPorts_Port_PortID",
                table: "LaptopPorts",
                column: "PortID",
                principalTable: "Port",
                principalColumn: "PortID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpus_Gpu_GpuID",
                table: "LaptopGpus");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopGpus_Laptops_LaptopID",
                table: "LaptopGpus");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPorts_Laptops_LaptopID",
                table: "LaptopPorts");

            migrationBuilder.DropForeignKey(
                name: "FK_LaptopPorts_Port_PortID",
                table: "LaptopPorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaptopPorts",
                table: "LaptopPorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaptopGpus",
                table: "LaptopGpus");

            migrationBuilder.RenameTable(
                name: "LaptopPorts",
                newName: "LaptopPort");

            migrationBuilder.RenameTable(
                name: "LaptopGpus",
                newName: "LaptopGpu");

            migrationBuilder.RenameIndex(
                name: "IX_LaptopPorts_PortID",
                table: "LaptopPort",
                newName: "IX_LaptopPort_PortID");

            migrationBuilder.RenameIndex(
                name: "IX_LaptopGpus_GpuID",
                table: "LaptopGpu",
                newName: "IX_LaptopGpu_GpuID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaptopPort",
                table: "LaptopPort",
                columns: new[] { "LaptopID", "PortID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaptopGpu",
                table: "LaptopGpu",
                columns: new[] { "LaptopID", "GpuID" });

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpu_Gpu_GpuID",
                table: "LaptopGpu",
                column: "GpuID",
                principalTable: "Gpu",
                principalColumn: "GpuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopGpu_Laptops_LaptopID",
                table: "LaptopGpu",
                column: "LaptopID",
                principalTable: "Laptops",
                principalColumn: "LaptopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPort_Laptops_LaptopID",
                table: "LaptopPort",
                column: "LaptopID",
                principalTable: "Laptops",
                principalColumn: "LaptopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaptopPort_Port_PortID",
                table: "LaptopPort",
                column: "PortID",
                principalTable: "Port",
                principalColumn: "PortID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
