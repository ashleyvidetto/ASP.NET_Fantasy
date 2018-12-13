using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FantasyAppData.Migrations
{
    public partial class addedcustomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Player",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Lineups",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_CustomerId",
                table: "Lineups",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Customer_CustomerId",
                table: "Lineups",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Customer_CustomerId",
                table: "Lineups");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Lineups_CustomerId",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Lineups");
        }
    }
}
