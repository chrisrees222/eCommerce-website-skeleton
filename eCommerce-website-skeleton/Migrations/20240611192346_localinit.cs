using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce_website_skeleton.Migrations
{
    public partial class localinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actor_ActorID",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actor_ActorID",
                table: "Actor_Movies",
                column: "ActorID",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
