using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtbRepository.Migrations
{
    public partial class IngredientMeasure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Drinks_DrinkId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_DrinkId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "IngredientsMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    MeasureId = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientsMeasures_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsMeasures_DrinkId",
                table: "IngredientsMeasures",
                column: "DrinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientsMeasures");

            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_DrinkId",
                table: "Ingredients",
                column: "DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Drinks_DrinkId",
                table: "Ingredients",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id");
        }
    }
}
