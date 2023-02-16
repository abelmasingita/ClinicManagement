using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicManagement.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "contact", "email", "first_name", "last_name", "speciality" },
                values: new object[,]
                {
                    { 1, "074 226 1505", "hlongwaniab@gmail.com", "Masingita", "Hlongwani", "Children" },
                    { 2, "074 226 1505", "abelmasingita9@gmail.com", "Abel", "Hlongwani", "Teeth" },
                    { 3, "074 226 1505", "abelmasingita9@gmail.com", "Moses", "Hlongwani", "Eyes" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "contact", "dateOfBirth", "email", "first_name", "gender", "last_name" },
                values: new object[,]
                {
                    { 1, "074 226 1505", "20010607", "hlongwaniabb@gmail.com", "Masingitas", "Male", "Hlongwanii" },
                    { 2, "074 226 1505", "20010607", "abelmasingita9@gmail.com", "Abel", "Male", "Hlongwani" },
                    { 3, "074 226 1505", "20010607", "abelmasingita9@gmail.com", "Moses", "Male", "Hlongwani" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "contact", "email", "first_name", "last_name", "position" },
                values: new object[,]
                {
                    { 1, "074 226 1505", "hlongwaniab@gmail.com", "Masingitaaa", "Hlongwani", "Nurse" },
                    { 2, "074 226 1505", "abelmasingita9@gmail.com", "Abelll", "Hlongwani", "Nurse" },
                    { 3, "074 226 1505", "abelmasingita9@gmail.com", "Mosesss", "Hlongwani", "Nurse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
