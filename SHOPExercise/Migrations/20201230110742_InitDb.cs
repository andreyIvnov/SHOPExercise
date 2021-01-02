using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SHOPExercise.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "Photo", "Price" },
                values: new object[] { 1, "Fish Scales :)", "Scale", "https://img.likeness.ru/83/62/8362/1439702784.jpg", 50.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "Photo", "Price" },
                values: new object[] { 2, "Fantastic Troll ass", "Troll ass", "https://www.jeremyriad.com/wp-content/uploads/2017/03/Trump_Troll_Doll4-550x698.jpeg", 300.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
