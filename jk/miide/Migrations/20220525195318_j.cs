using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class j : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternative_table");

            migrationBuilder.CreateTable(
                name: "symptomes_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_of_symptomes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_symptomes_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sym_disease_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diseaseId = table.Column<int>(type: "int", nullable: false),
                    symptomesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sym_disease_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_sym_disease_table_diseases_table_diseaseId",
                        column: x => x.diseaseId,
                        principalTable: "diseases_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sym_disease_table_symptomes_table_symptomesId",
                        column: x => x.symptomesId,
                        principalTable: "symptomes_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sym_disease_table_diseaseId",
                table: "sym_disease_table",
                column: "diseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_sym_disease_table_symptomesId",
                table: "sym_disease_table",
                column: "symptomesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sym_disease_table");

            migrationBuilder.DropTable(
                name: "symptomes_table");

            migrationBuilder.CreateTable(
                name: "alternative_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alt_drugId = table.Column<int>(type: "int", nullable: true),
                    drugId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternative_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_alternative_table_alternative_table_alt_drugId",
                        column: x => x.alt_drugId,
                        principalTable: "alternative_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alternative_table_drug_table_drugId",
                        column: x => x.drugId,
                        principalTable: "drug_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternative_table_alt_drugId",
                table: "alternative_table",
                column: "alt_drugId");

            migrationBuilder.CreateIndex(
                name: "IX_alternative_table_drugId",
                table: "alternative_table",
                column: "drugId");
        }
    }
}
