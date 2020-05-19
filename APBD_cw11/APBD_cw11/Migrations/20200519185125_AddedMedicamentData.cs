using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_cw11.Migrations
{
    public partial class AddedMedicamentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[] { 1, "fajny", "acodin", "potezny" });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[] { 2, "na przeziebienie", "rutinoscorbin", "bez recepty" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 51, 24, 915, DateTimeKind.Local).AddTicks(7453));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 47, 23, 676, DateTimeKind.Local).AddTicks(5247));
        }
    }
}
