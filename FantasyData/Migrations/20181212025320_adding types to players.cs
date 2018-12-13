using Microsoft.EntityFrameworkCore.Migrations;

namespace FantasyAppData.Migrations
{
    public partial class addingtypestoplayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_DefenseId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_FlexId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_QBId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_RB1Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_RB2Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_TEId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_WR1Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Player_WR2Id",
                table: "Lineups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Players");

            migrationBuilder.RenameColumn(
                name: "salaryCost",
                table: "Players",
                newName: "SalaryCost");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_DefenseId",
                table: "Lineups",
                column: "DefenseId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_FlexId",
                table: "Lineups",
                column: "FlexId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_QBId",
                table: "Lineups",
                column: "QBId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_RB1Id",
                table: "Lineups",
                column: "RB1Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_RB2Id",
                table: "Lineups",
                column: "RB2Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_TEId",
                table: "Lineups",
                column: "TEId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_WR1Id",
                table: "Lineups",
                column: "WR1Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Players_WR2Id",
                table: "Lineups",
                column: "WR2Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_DefenseId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_FlexId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_QBId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_RB1Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_RB2Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_TEId",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_WR1Id",
                table: "Lineups");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineups_Players_WR2Id",
                table: "Lineups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Player");

            migrationBuilder.RenameColumn(
                name: "SalaryCost",
                table: "Player",
                newName: "salaryCost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_DefenseId",
                table: "Lineups",
                column: "DefenseId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_FlexId",
                table: "Lineups",
                column: "FlexId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_QBId",
                table: "Lineups",
                column: "QBId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_RB1Id",
                table: "Lineups",
                column: "RB1Id",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_RB2Id",
                table: "Lineups",
                column: "RB2Id",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_TEId",
                table: "Lineups",
                column: "TEId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_WR1Id",
                table: "Lineups",
                column: "WR1Id",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lineups_Player_WR2Id",
                table: "Lineups",
                column: "WR2Id",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
