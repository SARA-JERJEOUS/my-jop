using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class yu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "diseases_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_OF_disease = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    trade_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scientific_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicine_caliber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    package_size = table.Column<int>(type: "int", nullable: false),
                    The_number_of_medicine = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    path_img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    how_to_use = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titel = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sideeffect_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expiration_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    When_to_consult__doctor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideeffect_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "alternative_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugId = table.Column<int>(type: "int", nullable: true),
                    alt_drugId = table.Column<int>(type: "int", nullable: true)
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
                name: "user_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone_number = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_table", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_table_role_table_roleId",
                        column: x => x.roleId,
                        principalTable: "role_table",
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

            migrationBuilder.CreateIndex(
                name: "IX_alternative_table_alt_drugId",
                table: "alternative_table",
                column: "alt_drugId");

            migrationBuilder.CreateIndex(
                name: "IX_alternative_table_drugId",
                table: "alternative_table",
                column: "drugId");

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
                name: "IX_user_table_roleId",
                table: "user_table",
                column: "roleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternative_table");

            migrationBuilder.DropTable(
                name: "disease_drug_table");

            migrationBuilder.DropTable(
                name: "sideDrug_table");

            migrationBuilder.DropTable(
                name: "user_table");

            migrationBuilder.DropTable(
                name: "diseases_table");

            migrationBuilder.DropTable(
                name: "drug_table");

            migrationBuilder.DropTable(
                name: "sideeffect_table");

            migrationBuilder.DropTable(
                name: "role_table");
        }
    }
}
