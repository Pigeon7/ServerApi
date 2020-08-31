using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerApi.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempAndHumidEntities");

            migrationBuilder.CreateTable(
                name: "SensorsReadEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperatureValue = table.Column<float>(nullable: false),
                    HumidityValue = table.Column<int>(nullable: false),
                    ReadTimeMilis = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorsReadings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorsReadEntities");

            migrationBuilder.CreateTable(
                name: "TempAndHumidEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HumidityValue = table.Column<int>(type: "int", nullable: false),
                    ReadTimeMilis = table.Column<long>(type: "bigint", nullable: false),
                    TemperatureValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempAndHumidEntities", x => x.Id);
                });
        }
    }
}
