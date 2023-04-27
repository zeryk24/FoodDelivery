using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class AddAddressToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
                columns: new[] { "AddressId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 1, "59a51caf-5000-4b36-91a3-165416509194", "AQAAAAEAACcQAAAAECgZJmTyyzyPHl1q74oh+dxnDvA+j9TtrvLfVUisXBDWheTXsUQc5hnwdEO8vZ7eHQ==", "AB1F0636140C4771995B5D0105E87409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca058853-78e1-47af-9699-655b13bf3531", "AQAAAAEAACcQAAAAEAY4dVYYAcSLhtWyizCRZGerB6FfzhnT3W3UQyHusdMubl7EpNiR2NWysKDlbToOCw==", "949401AA245343619ED1D6D2DBEA0996" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "728cc5cc-f296-4536-b0fc-2492d71a3310");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ba4ff8a7-f379-4b7c-b952-8dda54bc2cf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cd72a289-aabb-4e04-b58d-1e80267cc62c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9186e4b6-93e3-4f6e-b217-4fed0c8f703d", "AQAAAAEAACcQAAAAEC4zE46gfcYaGw08T98rHmA7VVyepWOzOc+tDMj860EgTXOhMpX6kanVD6LVuGTcwg==", "45081D35F2A54731819265CFE6D26508" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48e1c764-38d9-4608-b78c-5c92543038a7", "AQAAAAEAACcQAAAAED/NZu0IoOIvICwvn28EGgp3Z/bEFs2BMrlFOeQCN/PblnPK4ZMVmEmd/tspLg3+7Q==", "797A77F0C84F486291E88CB5B582673C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9bbec6d-38ca-49a1-a8e3-ad0ea736ed2d", "AQAAAAEAACcQAAAAENRk7QuLE9nriRaDitKWmXhOgRbuPq29voBTx7s5V3vG/3ELghR/9HTeoyHYwWW3dw==", "1E20F0F40D434A22A2CDD8EA0F9E55AC" });
        }
    }
}
