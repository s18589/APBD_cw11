using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_cw11.Migrations
{
    public partial class AddedPrescriptionMedicamentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 58, 15, 329, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 19, 20, 58, 15, 332, DateTimeKind.Local).AddTicks(5085), new DateTime(2020, 5, 19, 20, 58, 15, 332, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 19, 20, 58, 15, 332, DateTimeKind.Local).AddTicks(6729), new DateTime(2020, 5, 19, 20, 58, 15, 332, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.InsertData(
                table: "PrescrtiptionMedicaments",
                columns: new[] { "IdPrescription", "IdMedicament", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "xxx", 10 },
                    { 1, 2, "yyy", 20 },
                    { 2, 1, "ccc", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrescrtiptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescrtiptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PrescrtiptionMedicaments",
                keyColumns: new[] { "IdPrescription", "IdMedicament" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 5, 19, 20, 55, 35, 171, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 5, 19, 20, 55, 35, 173, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(824), new DateTime(2020, 5, 19, 20, 55, 35, 174, DateTimeKind.Local).AddTicks(850) });
        }
    }
}
