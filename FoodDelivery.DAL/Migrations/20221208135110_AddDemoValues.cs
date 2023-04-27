using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class AddDemoValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantEntityUserEntity");

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AddressEntity",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2, 0, "48e1c764-38d9-4608-b78c-5c92543038a7", "marek@example.com", true, false, null, "Marek", "MAREK@EXAMPLE.COM", "MAREK@EXAMPLE.COM", "AQAAAAEAACcQAAAAED/NZu0IoOIvICwvn28EGgp3Z/bEFs2BMrlFOeQCN/PblnPK4ZMVmEmd/tspLg3+7Q==", null, false, "797A77F0C84F486291E88CB5B582673C", "Macho", false, "marek@example.com" },
                    { 3, 0, "e9bbec6d-38ca-49a1-a8e3-ad0ea736ed2d", "erik@example.com", true, false, null, "Erik", "ERIK@EXAMPLE.COM", "ERIK@EXAMPLE.COM", "AQAAAAEAACcQAAAAENRk7QuLE9nriRaDitKWmXhOgRbuPq29voBTx7s5V3vG/3ELghR/9HTeoyHYwWW3dw==", null, false, "1E20F0F40D434A22A2CDD8EA0F9E55AC", "Baca", false, "erik@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "FeedbackEntity",
                columns: new[] { "Id", "Description", "MealId", "Rating", "RestaurantId", "UserId" },
                values: new object[,]
                {
                    { 1, "Too bad... Didn't like it at all.", 1, 1, null, 2 },
                    { 2, "Eh...", 2, 2, null, 2 },
                    { 3, "Not great, not terrible.", 3, 3, null, 2 },
                    { 4, "Liked it a lot!!", 4, 4, null, 2 },
                    { 5, "Awesome! Best thing I ever eaten!", 5, 5, null, 2 },
                    { 6, "Awesome! Best thing I ever eaten!", 6, 5, null, 2 },
                    { 7, "Liked it a lot!!", 7, 4, null, 2 },
                    { 8, "Not great, not terrible.", 8, 3, null, 2 },
                    { 9, "Eh...", 9, 2, null, 2 },
                    { 10, "Too bad... Didn't like it at all.", 10, 1, null, 2 },
                    { 11, "Really bad place.", null, 1, 1, 2 },
                    { 12, "Won't come again...", null, 2, 2, 2 },
                    { 13, "Could have been better.", null, 3, 3, 2 },
                    { 14, "Great place!", null, 4, 4, 2 },
                    { 15, "My favorite place! I highly recommend!", null, 5, 5, 2 },
                    { 16, "My favorite place! I highly recommend!", null, 5, 6, 2 },
                    { 17, "Great place!", null, 4, 7, 2 },
                    { 18, "Could have been better.", null, 3, 8, 2 },
                    { 19, "Won't come again...", null, 2, 9, 2 },
                    { 20, "Really bad place.", null, 1, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderEntity",
                columns: new[] { "Id", "AddressId", "PaymentType", "RestaurantId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, 2 },
                    { 2, 1, 0, 2, 2 },
                    { 3, 1, 0, 3, 2 },
                    { 4, 1, 0, 4, 2 },
                    { 5, 1, 0, 5, 2 },
                    { 6, 1, 1, 6, 2 },
                    { 7, 1, 1, 7, 2 },
                    { 8, 1, 1, 8, 2 },
                    { 9, 1, 1, 9, 2 },
                    { 10, 1, 2, 10, 2 }
                });

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

            migrationBuilder.InsertData(
                table: "OrderItemEntity",
                columns: new[] { "Id", "Amount", "MealId", "OrderId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, 10.5 },
                    { 2, 3, 3, 1, 8.5999999999999996 },
                    { 3, 1, 2, 2, 15.199999999999999 },
                    { 4, 1, 3, 2, 8.5999999999999996 },
                    { 5, 2, 4, 2, 16.5 },
                    { 6, 1, 1, 3, 10.5 },
                    { 7, 1, 10, 3, 8.0 },
                    { 8, 5, 7, 4, 8.0 },
                    { 9, 2, 5, 5, 5.0999999999999996 },
                    { 10, 4, 9, 6, 11.300000000000001 },
                    { 11, 1, 7, 7, 8.0 },
                    { 12, 4, 8, 8, 10.5 },
                    { 13, 3, 9, 9, 11.300000000000001 },
                    { 14, 1, 6, 9, 7.0999999999999996 },
                    { 15, 1, 1, 10, 10.5 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FeedbackEntity",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItemEntity",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderEntity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RestaurantEntity");

            migrationBuilder.CreateTable(
                name: "RestaurantEntityUserEntity",
                columns: table => new
                {
                    ManagersId = table.Column<int>(type: "int", nullable: false),
                    RestaurantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantEntityUserEntity", x => new { x.ManagersId, x.RestaurantsId });
                    table.ForeignKey(
                        name: "FK_RestaurantEntityUserEntity_AspNetUsers_ManagersId",
                        column: x => x.ManagersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantEntityUserEntity_RestaurantEntity_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "RestaurantEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddressEntity",
                columns: new[] { "Id", "City", "Number", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 2, "New York", "3435", "10019", "Briercliff Road" },
                    { 3, "New York", "1079", "10001", "Layman Court" },
                    { 4, "New York", "3521", "10011", "Farnum Road" },
                    { 5, "New York", "676", "10013", "My Drive" },
                    { 6, "New York", "1702", "10011", "Oakwood Avenue" },
                    { 7, "New York", "2187", "10014", "Duncan Avenue" },
                    { 8, "New York", "2952", "10013", "Old Dear Lane" },
                    { 9, "New York", "3872", "10007", "Settlers Lane" },
                    { 10, "New York", "1264", "10007", "Geraldine Lane" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "572eafb0-6fc4-4c8c-a6f0-4d80f9d5837e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a6bde293-22fb-4af2-9a19-281957d03059");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7e192a91-123d-42b9-9983-70a158b476ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e366a52-6dda-4b9e-a617-abc57889879c", "AQAAAAEAACcQAAAAEIfyHQNXep38/hmzFM2pnJykfEOj46tqQuyPLUKWIMMoqHvsvYB2uWodlvGLhi8l9g==", "47658819AB94405AA00DA0AF4213E809" });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEntityUserEntity_RestaurantsId",
                table: "RestaurantEntityUserEntity",
                column: "RestaurantsId");
        }
    }
}
