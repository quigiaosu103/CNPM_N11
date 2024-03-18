using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNPM.Migrations
{
    public partial class updateCustomerTAble1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_CustomerUserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerUserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerUserId1",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerUserId1",
                table: "Orders",
                type: "varchar(95)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerUserId1",
                table: "Orders",
                column: "CustomerUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_CustomerUserId1",
                table: "Orders",
                column: "CustomerUserId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
