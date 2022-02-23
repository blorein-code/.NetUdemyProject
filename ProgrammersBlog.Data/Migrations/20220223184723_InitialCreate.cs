using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(979), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2682), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2691), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 2, 23, 21, 47, 23, 217, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2235), new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 2, 23, 21, 47, 23, 219, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6049), new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6070), new DateTime(2022, 2, 23, 21, 47, 23, 220, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 221, DateTimeKind.Local).AddTicks(7168), new DateTime(2022, 2, 23, 21, 47, 23, 221, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 21, 47, 23, 225, DateTimeKind.Local).AddTicks(9375), new DateTime(2022, 2, 23, 21, 47, 23, 225, DateTimeKind.Local).AddTicks(9383) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4775), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4773), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 2, 23, 20, 15, 4, 487, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3964), new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3969), new DateTime(2022, 2, 23, 20, 15, 4, 489, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7360), new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7365), new DateTime(2022, 2, 23, 20, 15, 4, 490, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 491, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 2, 23, 20, 15, 4, 491, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 23, 20, 15, 4, 495, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 2, 23, 20, 15, 4, 495, DateTimeKind.Local).AddTicks(8768) });
        }
    }
}
