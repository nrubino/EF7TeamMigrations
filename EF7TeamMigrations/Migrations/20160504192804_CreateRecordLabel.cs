using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace EF7TeamMigrations.Migrations
{
    public partial class CreateRecordLabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Album_Artist_ArtistId", table: "Album");
            migrationBuilder.CreateTable(
                name: "RecordLabel",
                columns: table => new
                {
                    RecordLabelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordLabel", x => x.RecordLabelId);
                });
            migrationBuilder.AddColumn<int>(
                name: "RecordLabelId",
                table: "Album",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Album_RecordLabel_RecordLabelId",
                table: "Album",
                column: "RecordLabelId",
                principalTable: "RecordLabel",
                principalColumn: "RecordLabelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Album_Artist_ArtistId", table: "Album");
            migrationBuilder.DropForeignKey(name: "FK_Album_RecordLabel_RecordLabelId", table: "Album");
            migrationBuilder.DropColumn(name: "RecordLabelId", table: "Album");
            migrationBuilder.DropTable("RecordLabel");
            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
