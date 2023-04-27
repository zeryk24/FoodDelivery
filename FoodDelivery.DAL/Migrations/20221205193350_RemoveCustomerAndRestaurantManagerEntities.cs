using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class RemoveCustomerAndRestaurantManagerEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackEntity_CustomerEntity_UserId",
                table: "FeedbackEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderEntity_CustomerEntity_UserId",
                table: "OrderEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentCardEntity_CustomerEntity_UserId",
                table: "PaymentCardEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantEntity_RestaurantManagerEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity");

            migrationBuilder.DropTable(
                name: "CustomerEntity");

            migrationBuilder.DropTable(
                name: "RestaurantManagerEntity");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity");

            migrationBuilder.DropColumn(
                name: "RestaurantManagerEntityId",
                table: "RestaurantEntity");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
                value: "2827a27a-71c5-48d8-8ee5-5239b568d1b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d46b3b23-0399-40e5-a493-92e5fb9cb5a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b05a9d5a-c134-4a56-97d1-0d622877d9a2");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEntityUserEntity_RestaurantsId",
                table: "RestaurantEntityUserEntity",
                column: "RestaurantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackEntity_AspNetUsers_UserId",
                table: "FeedbackEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderEntity_AspNetUsers_UserId",
                table: "OrderEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentCardEntity_AspNetUsers_UserId",
                table: "PaymentCardEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AddressEntity_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackEntity_AspNetUsers_UserId",
                table: "FeedbackEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderEntity_AspNetUsers_UserId",
                table: "OrderEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentCardEntity_AspNetUsers_UserId",
                table: "PaymentCardEntity");

            migrationBuilder.DropTable(
                name: "RestaurantEntityUserEntity");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantManagerEntityId",
                table: "RestaurantEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    UserEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerEntity_AddressEntity_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerEntity_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantManagerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantManagerEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantManagerEntity_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e51e72b0-ef13-42a0-b341-aa907c6416c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "08535f3f-d313-4b52-bd93-c5b64a837faa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0f3bd07f-1e14-4ece-b735-a5e4641e1d6c");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity",
                column: "RestaurantManagerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEntity_AddressId",
                table: "CustomerEntity",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEntity_UserEntityId",
                table: "CustomerEntity",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantManagerEntity_UserEntityId",
                table: "RestaurantManagerEntity",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackEntity_CustomerEntity_UserId",
                table: "FeedbackEntity",
                column: "UserId",
                principalTable: "CustomerEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderEntity_CustomerEntity_UserId",
                table: "OrderEntity",
                column: "UserId",
                principalTable: "CustomerEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentCardEntity_CustomerEntity_UserId",
                table: "PaymentCardEntity",
                column: "UserId",
                principalTable: "CustomerEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantEntity_RestaurantManagerEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity",
                column: "RestaurantManagerEntityId",
                principalTable: "RestaurantManagerEntity",
                principalColumn: "Id");
        }
    }
}
