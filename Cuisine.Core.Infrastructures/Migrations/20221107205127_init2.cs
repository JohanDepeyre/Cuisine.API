using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cuisine.Core.Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recette_Recettes_RecetteId",
                table: "Recette");

            migrationBuilder.DropTable(
                name: "Recettes");

            migrationBuilder.DropIndex(
                name: "IX_Recette_RecetteId",
                table: "Recette");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Recette");

            migrationBuilder.DropColumn(
                name: "RecetteId",
                table: "Recette");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Recette");

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecetteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Recette_RecetteId",
                        column: x => x.RecetteId,
                        principalTable: "Recette",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_RecetteId",
                table: "Photo",
                column: "RecetteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Recette",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RecetteId",
                table: "Recette",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Recette",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Recettes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recettes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recette_RecetteId",
                table: "Recette",
                column: "RecetteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recette_Recettes_RecetteId",
                table: "Recette",
                column: "RecetteId",
                principalTable: "Recettes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
