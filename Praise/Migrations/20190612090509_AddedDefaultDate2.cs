using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Praize.Api.Migrations
{
    public partial class AddedDefaultDate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 87, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Roles",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "AddressTypes",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Addresses",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Users",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 87, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Roles",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "AddressTypes",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Addresses",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2019, 6, 12, 8, 37, 52, 88, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");
        }
    }
}
