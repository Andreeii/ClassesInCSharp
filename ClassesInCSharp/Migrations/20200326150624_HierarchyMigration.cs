using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassesInCSharp.Migrations
{
    public partial class HierarchyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enginepower = table.Column<int>(nullable: false),
                    EngineVolume = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AudiCaracteristic1 = table.Column<string>(nullable: true),
                    AudiCaracteristic2 = table.Column<string>(nullable: true),
                    BMWCharacteristic1 = table.Column<string>(nullable: true),
                    BMWCharacteristic2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
