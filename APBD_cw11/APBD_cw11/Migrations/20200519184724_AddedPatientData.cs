using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_cw11.Migrations
{
    public partial class AddedPatientData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2020, 5, 19, 20, 47, 23, 676, DateTimeKind.Local).AddTicks(5247), "AAA", "BBB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
