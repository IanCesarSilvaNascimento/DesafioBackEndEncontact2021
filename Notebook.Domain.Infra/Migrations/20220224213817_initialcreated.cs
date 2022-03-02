using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notebook.Domain.Infra.Migrations
{
    public partial class initialcreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar", maxLength: 160, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldate", nullable: false),
                    User = table.Column<string>(type: "varchar", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_User",
                table: "Company",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
