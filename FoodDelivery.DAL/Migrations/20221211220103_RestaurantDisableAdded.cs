using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class RestaurantDisableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disabled",
                table: "RestaurantEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1bb8d85e-dff4-4b76-b43f-950fa18c7517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c8d6793b-fecd-41fe-9ac6-67fa70a40117");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8d4471f0-63c4-4326-88ff-1e10fcab09e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828c2f25-a191-424c-9a1d-3aa043285cce", "AQAAAAEAACcQAAAAEKyK5Bs1YtiaR76UmHZzLXwOXvCD38auoP8CNeF5NBbEGCczB7Z3lQ/7VGWu3ng4wg==", "8233899BA9A147E395A8B9373AAFAC71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ecbabc3-f763-46ab-a213-a70a36cf5294", "AQAAAAEAACcQAAAAEAI2UUOCpf9rjUm8Ce7e+nExaed8uuemOlmGhFrx1Dkt6Umev9469VMaHZtSEpwvJg==", "9AAF9A796944471D82FFD1317EFF415F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5444731c-8280-4089-8c16-851e4e6784ea", "AQAAAAEAACcQAAAAEM7Q0bvB2dV7ywkAh34ErU+sIyvBrqOrxKBYazyiltwZSCbwHRQ5x1/x+nSX/wiGNQ==", "7F0B0494D94F432988249B3679D34304" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disabled",
                table: "RestaurantEntity");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cabfb76b-d88c-41cf-87fa-6dc6604cf862");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e770c576-bd89-44c7-bc01-55d5b55d5699");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7bd792c0-9985-42bc-b836-aea3cf055d50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4375e76-f2b2-41b3-96d5-956c6ff30749", "AQAAAAEAACcQAAAAEEjpFSq3AD+pn7dpOjSpABUYT5H8EFdbQbJVHNX1jB5hTruhAV7dGTONIM2lNV/C8Q==", "ECDA7F8E83B8439DAB5F4B24DC16D480" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59a51caf-5000-4b36-91a3-165416509194", "AQAAAAEAACcQAAAAECgZJmTyyzyPHl1q74oh+dxnDvA+j9TtrvLfVUisXBDWheTXsUQc5hnwdEO8vZ7eHQ==", "AB1F0636140C4771995B5D0105E87409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca058853-78e1-47af-9699-655b13bf3531", "AQAAAAEAACcQAAAAEAY4dVYYAcSLhtWyizCRZGerB6FfzhnT3W3UQyHusdMubl7EpNiR2NWysKDlbToOCw==", "949401AA245343619ED1D6D2DBEA0996" });
        }
    }
}
