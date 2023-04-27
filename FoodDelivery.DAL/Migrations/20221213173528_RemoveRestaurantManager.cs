using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class RemoveRestaurantManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantEntity_AspNetUsers_UserId",
                table: "RestaurantEntity");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantEntity_UserId",
                table: "RestaurantEntity");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RestaurantEntity");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "03f744b6-1e51-4ce6-abca-fa8faadad503");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c28976a9-6c39-4691-a0dc-d08742b67089");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87273f2-051c-4496-970c-75e4bb86be41", "AQAAAAEAACcQAAAAEJeKJ8P325zcvS4xXjJeEWPBkV9rWizpodq0WNcVz8WPdSeDxF84cXyl+XOByB4pMw==", "8F180DE7183C48DFA0727158294BC650" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61dcdd9b-7be9-4bd8-a2e3-ce1327de6653", "AQAAAAEAACcQAAAAEIv+TtgUg8LTFCw6sNIqVlSv80ZOm9YVH54fvaiF1RKHKWr/Vk4ePCkwJuntIaLgww==", "0B80BDB69C1A48EEB3D7945C53004B38" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RestaurantEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "8d4471f0-63c4-4326-88ff-1e10fcab09e9", "RestaurantManager", "RESTAURANTMANAGER" });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, null, "5444731c-8280-4089-8c16-851e4e6784ea", "erik@example.com", true, false, null, "Erik", "ERIK@EXAMPLE.COM", "ERIK@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM7Q0bvB2dV7ywkAh34ErU+sIyvBrqOrxKBYazyiltwZSCbwHRQ5x1/x+nSX/wiGNQ==", null, false, "7F0B0494D94F432988249B3679D34304", "Baca", false, "erik@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantEntity",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEntity_UserId",
                table: "RestaurantEntity",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantEntity_AspNetUsers_UserId",
                table: "RestaurantEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
