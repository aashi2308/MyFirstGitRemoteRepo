using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentPropertySystem.Migrations
{
    public partial class AgentProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    PropertyID = table.Column<Guid>(nullable: false),
                    PropertyName = table.Column<string>(nullable: true),
                    PropertyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyID);
                });

            migrationBuilder.CreateTable(
                name: "AgentDetails",
                columns: table => new
                {
                    AgentID = table.Column<Guid>(nullable: false),
                    AgentName = table.Column<string>(nullable: true),
                    AgentAge = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    PropertyDetailPropertyID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentDetails", x => x.AgentID);
                    table.ForeignKey(
                        name: "FK_AgentDetails_PropertyDetails_PropertyDetailPropertyID",
                        column: x => x.PropertyDetailPropertyID,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgentDetails_PropertyDetailPropertyID",
                table: "AgentDetails",
                column: "PropertyDetailPropertyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentDetails");

            migrationBuilder.DropTable(
                name: "PropertyDetails");
        }
    }
}
