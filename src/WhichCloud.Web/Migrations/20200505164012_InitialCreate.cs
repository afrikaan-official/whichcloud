using Microsoft.EntityFrameworkCore.Migrations;

namespace WhichCloud.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VMTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VMs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VMTypeId = table.Column<int>(nullable: true),
                    Memory = table.Column<int>(nullable: false),
                    CPU = table.Column<int>(nullable: false),
                    Storage = table.Column<int>(nullable: false),
                    Bandwidth = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VMs_VMTypes_VMTypeId",
                        column: x => x.VMTypeId,
                        principalTable: "VMTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VMs_VMTypeId",
                table: "VMs",
                column: "VMTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VMs");

            migrationBuilder.DropTable(
                name: "VMTypes");
        }
    }
}
