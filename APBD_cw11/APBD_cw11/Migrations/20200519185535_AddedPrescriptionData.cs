using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_cw11.Migrations
{
    public partial class AddedPrescriptionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 55, 35, 171, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 2, new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(824), new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(850), 2, 1 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9629), 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 51, 24, 915, DateTimeKind.Local).AddTicks(7453));
        }
    }
}
