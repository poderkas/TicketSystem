using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSystem.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 43, 29, 449, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 43, 29, 449, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 43, 29, 449, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 43, 29, 449, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 43, 29, 449, DateTimeKind.Utc).AddTicks(9928));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 25, 0, 32, 38, 16, DateTimeKind.Utc).AddTicks(6785));
        }
    }
}
