﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace webapp.Migrations
{
    public partial class WachtrijCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Peercoach = table.Column<string>(nullable: false),
                    Lokaal = table.Column<string>(nullable: true),
                    Tijdvak = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Wachtrij");
        }
    }
}