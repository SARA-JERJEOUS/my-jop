using Microsoft.EntityFrameworkCore.Migrations;

namespace DALco.Migrations
{
    public partial class U : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sideDrug_table");

            migrationBuilder.DropTable(
                name: "sideeffect_table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sideeffect_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expiration_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    When_to_consult__doctor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideeffect_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sideDrug_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugId = table.Column<int>(type: "int", nullable: false),
                    sideeffectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideDrug_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_sideDrug_table_drug_table_drugId",
                        column: x => x.drugId,
                        principalTable: "drug_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sideDrug_table_sideeffect_table_sideeffectId",
                        column: x => x.sideeffectId,
                        principalTable: "sideeffect_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sideDrug_table_drugId",
                table: "sideDrug_table",
                column: "drugId");

            migrationBuilder.CreateIndex(
                name: "IX_sideDrug_table_sideeffectId",
                table: "sideDrug_table",
                column: "sideeffectId");
        }
    }
}
