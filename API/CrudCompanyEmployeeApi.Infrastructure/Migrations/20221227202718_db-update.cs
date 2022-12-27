using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCompanyEmployeeApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyAddress");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Company");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraInfo",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Company",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ExtraInfo",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Company",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Cep = table.Column<string>(type: "VARCHAR(8)", nullable: false),
                    ExtraInfo = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Neighborhood = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Number = table.Column<string>(type: "VARCHAR(6)", nullable: false),
                    State = table.Column<string>(type: "CHAR(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAddress_Company_Id",
                        column: x => x.Id,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
