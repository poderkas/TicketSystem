using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketSystem.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SubmissionTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompletionDeadline = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CompletionDeadline", "Description", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2030, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ticket1", new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6780) },
                    { 2, new DateTime(2040, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ticket2", new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6783) },
                    { 3, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ticket3", new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6784) },
                    { 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ticket4", new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6785) },
                    { 5, new DateTime(2060, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ticket5", new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6785) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
