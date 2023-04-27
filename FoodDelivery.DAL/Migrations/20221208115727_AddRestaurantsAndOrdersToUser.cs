using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class AddRestaurantsAndOrdersToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantEntityUserEntity");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c065a89b-2875-4d11-91b1-b04447c44ad1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9cafe291-986c-474c-96d9-b4b4060b2005");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a95d55cf-c2bf-4bb2-8435-46959092d282");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7dfc25b-4356-4e91-9c36-671f8154aa23", "AQAAAAEAACcQAAAAED357uH4/mM4vZ6bsJ8tiRxPdU+LzpoBcevQkIO5iEWs90BVXt49XdA/oPBUuNvqeQ==", "D13FB1351F24485A95D90AFDF6E359BA" });
        }
    }
}
