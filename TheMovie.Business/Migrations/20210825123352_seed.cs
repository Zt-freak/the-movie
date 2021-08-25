using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovie.Business.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Jaws", new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Luca", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Kill Bill", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bee Movie", new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Test", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
