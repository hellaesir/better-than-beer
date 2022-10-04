using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtbRepository.Migrations
{
    public partial class IngredientMeasureFks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IngredientsMeasures_IngredientId",
                table: "IngredientsMeasures",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsMeasures_MeasureId",
                table: "IngredientsMeasures",
                column: "MeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsMeasures_Ingredients_IngredientId",
                table: "IngredientsMeasures",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsMeasures_Measures_MeasureId",
                table: "IngredientsMeasures",
                column: "MeasureId",
                principalTable: "Measures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsMeasures_Ingredients_IngredientId",
                table: "IngredientsMeasures");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsMeasures_Measures_MeasureId",
                table: "IngredientsMeasures");

            migrationBuilder.DropIndex(
                name: "IX_IngredientsMeasures_IngredientId",
                table: "IngredientsMeasures");

            migrationBuilder.DropIndex(
                name: "IX_IngredientsMeasures_MeasureId",
                table: "IngredientsMeasures");
        }
    }
}
