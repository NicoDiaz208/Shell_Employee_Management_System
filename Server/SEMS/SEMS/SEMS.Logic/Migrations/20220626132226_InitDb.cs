using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMS.Logic.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "App");

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TelNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Referal = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicants_Persons_Id",
                        column: x => x.Id,
                        principalSchema: "App",
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonForTermination = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Applicants_Id",
                        column: x => x.Id,
                        principalSchema: "App",
                        principalTable: "Applicants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SSN",
                schema: "App",
                table: "Persons",
                column: "SSN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Applicants",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Persons",
                schema: "App");
        }
    }
}
