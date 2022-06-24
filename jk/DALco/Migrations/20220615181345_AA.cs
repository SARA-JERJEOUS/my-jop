using Microsoft.EntityFrameworkCore.Migrations;

namespace DALco.Migrations
{
    public partial class AA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "diseases_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_OF_disease = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diseases_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drug_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trade_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scientific_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_caliber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    package_size = table.Column<int>(type: "int", nullable: false),
                    The_number_of_medicine = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    how_to_use = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sideeffect_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    When_to_consult__doctor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideeffect_table", x => x.id);
                });

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
                name: "user_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "disease_drug_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diseaseId = table.Column<int>(type: "int", nullable: false),
                    drugId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disease_drug_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_disease_drug_table_diseases_table_diseaseId",
                        column: x => x.diseaseId,
                        principalTable: "diseases_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_disease_drug_table_drug_table_drugId",
                        column: x => x.drugId,
                        principalTable: "drug_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sideDrug_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sideeffectId = table.Column<int>(type: "int", nullable: false),
                    drugId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_disease_drug_table_diseaseId",
                table: "disease_drug_table",
                column: "diseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_disease_drug_table_drugId",
                table: "disease_drug_table",
                column: "drugId");

            migrationBuilder.CreateIndex(
                name: "IX_sideDrug_table_drugId",
                table: "sideDrug_table",
                column: "drugId");

            migrationBuilder.CreateIndex(
                name: "IX_sideDrug_table_sideeffectId",
                table: "sideDrug_table",
                column: "sideeffectId");

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
                name: "disease_drug_table");

            migrationBuilder.DropTable(
                name: "sideDrug_table");

            migrationBuilder.DropTable(
                name: "sym_disease_table");

            migrationBuilder.DropTable(
                name: "user_table");

            migrationBuilder.DropTable(
                name: "drug_table");

            migrationBuilder.DropTable(
                name: "sideeffect_table");

            migrationBuilder.DropTable(
                name: "diseases_table");

            migrationBuilder.DropTable(
                name: "symptomes_table");
        }
    }
}
