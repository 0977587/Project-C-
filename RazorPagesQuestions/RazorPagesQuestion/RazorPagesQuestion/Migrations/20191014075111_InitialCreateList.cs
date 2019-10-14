using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesQuestion.Migrations
{
    public partial class InitialCreateList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WaitinglistID",
                table: "Question",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Waitinglist",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Starttime = table.Column<DateTime>(nullable: false),
                    Enddtime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waitinglist", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_WaitinglistID",
                table: "Question",
                column: "WaitinglistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Waitinglist_WaitinglistID",
                table: "Question",
                column: "WaitinglistID",
                principalTable: "Waitinglist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Waitinglist_WaitinglistID",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Waitinglist");

            migrationBuilder.DropIndex(
                name: "IX_Question_WaitinglistID",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "WaitinglistID",
                table: "Question");
        }
    }
}
