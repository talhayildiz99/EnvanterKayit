using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvanterKayit.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotationsEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "Email" },
                values: new object[] { new DateTime(2023, 5, 26, 15, 2, 17, 957, DateTimeKind.Local).AddTicks(7350), "admin@envanterkayit.tc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "Email" },
                values: new object[] { new DateTime(2023, 5, 25, 12, 3, 14, 18, DateTimeKind.Local).AddTicks(8260), "admin@otoservissatis.tc" });
        }
    }
}
