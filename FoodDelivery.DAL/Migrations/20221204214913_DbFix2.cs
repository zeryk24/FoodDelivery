using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    public partial class DbFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantManagerEntityId",
                table: "RestaurantEntity",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity",
                column: "RestaurantManagerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantManagerEntity_UserEntityId",
                table: "RestaurantManagerEntity",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantEntity_RestaurantManagerEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity",
                column: "RestaurantManagerEntityId",
                principalTable: "RestaurantManagerEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantEntity_RestaurantManagerEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity");

            migrationBuilder.DropTable(
                name: "RestaurantManagerEntity");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantEntity_RestaurantManagerEntityId",
                table: "RestaurantEntity");

            migrationBuilder.DropColumn(
                name: "RestaurantManagerEntityId",
                table: "RestaurantEntity");
        }
    }
}
