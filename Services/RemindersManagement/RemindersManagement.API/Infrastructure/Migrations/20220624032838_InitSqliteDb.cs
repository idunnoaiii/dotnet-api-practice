using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemindersManagement.API.Infrastructure.Migrations
{
    public partial class InitSqliteDb : Migration
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
                values: new object[] { new Guid("3a56dbde-f01e-4a34-89ec-b85f585d368a"), "Learning Microservices", 1 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("7b8a2f7f-9d99-4664-922b-bd7783770e2a"), "Presentation prepare", 0 });

            migrationBuilder.InsertData(
                schema: "reminders",
                table: "Reminders",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("ce811a26-5562-4d02-8fe1-a3ed174e72c0"), "Writing Blog", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminders",
                schema: "reminders");
        }
    }
}
