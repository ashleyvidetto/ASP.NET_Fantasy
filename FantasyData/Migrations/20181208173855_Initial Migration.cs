using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FantasyAppData.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    salaryCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lineups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QBId = table.Column<int>(nullable: true),
                    WR1Id = table.Column<int>(nullable: true),
                    WR2Id = table.Column<int>(nullable: true),
                    RB1Id = table.Column<int>(nullable: true),
                    RB2Id = table.Column<int>(nullable: true),
                    FlexId = table.Column<int>(nullable: true),
                    TEId = table.Column<int>(nullable: true),
                    DefenseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_DefenseId",
                        column: x => x.DefenseId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_FlexId",
                        column: x => x.FlexId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_QBId",
                        column: x => x.QBId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_RB1Id",
                        column: x => x.RB1Id,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_RB2Id",
                        column: x => x.RB2Id,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_TEId",
                        column: x => x.TEId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_WR1Id",
                        column: x => x.WR1Id,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lineups_Player_WR2Id",
                        column: x => x.WR2Id,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_DefenseId",
                table: "Lineups",
                column: "DefenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_FlexId",
                table: "Lineups",
                column: "FlexId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_QBId",
                table: "Lineups",
                column: "QBId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_RB1Id",
                table: "Lineups",
                column: "RB1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_RB2Id",
                table: "Lineups",
                column: "RB2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_TEId",
                table: "Lineups",
                column: "TEId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_WR1Id",
                table: "Lineups",
                column: "WR1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lineups_WR2Id",
                table: "Lineups",
                column: "WR2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lineups");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
