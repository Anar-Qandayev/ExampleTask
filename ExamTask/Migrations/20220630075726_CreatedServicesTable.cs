using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTask.Migrations
{
    public partial class CreatedServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TvName = table.Column<string>(nullable: true),
                    LabName = table.Column<string>(nullable: true),
                    CardName = table.Column<string>(nullable: true),
                    TvInformation = table.Column<string>(nullable: true),
                    LabInformation = table.Column<string>(nullable: true),
                    CardInformation = table.Column<string>(nullable: true),
                    TvText = table.Column<string>(nullable: true),
                    LabText = table.Column<string>(nullable: true),
                    CardText = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
