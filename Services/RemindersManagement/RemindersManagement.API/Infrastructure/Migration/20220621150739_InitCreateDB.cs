using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemindersManagement.API.Infrastructure.Migrations
{
    public partial class InitCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "reminders");

            migrationBuilder.CreateTable(
                name: "Reminders",
                schema: "reminders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("338dcd20-bcc6-432e-b26d-fcc3d4d07bfe"), "Presentation prepare", 0 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("73163bee-9059-4838-a535-6d46995da7fd"), "Writing Blog", 0 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("89fe00ac-d931-4227-8649-b83f7333aba7"), "Learning Microservices", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminders",
                schema: "reminders");
        }
    }
}
