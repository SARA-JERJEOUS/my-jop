using Microsoft.EntityFrameworkCore.Migrations;

namespace DALco.Migrations
{
    public partial class AAAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sym_disease_table");

            migrationBuilder.DropTable(
                name: "symptomes_table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "symptomes_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_of_symptomes = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
