using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Data.Migrations
{
    /// <inheritdoc />
    public partial class addListClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonList_ClientList_ClientID",
                table: "LessonList");

            migrationBuilder.DropIndex(
                name: "IX_LessonList_ClientID",
                table: "LessonList");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "LessonList");

            migrationBuilder.CreateTable(
                name: "ClientLesson",
                columns: table => new
                {
                    ClientLessonsID = table.Column<int>(type: "int", nullable: false),
                    clientsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLesson", x => new { x.ClientLessonsID, x.clientsID });
                    table.ForeignKey(
                        name: "FK_ClientLesson_ClientList_clientsID",
                        column: x => x.clientsID,
                        principalTable: "ClientList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLesson_LessonList_ClientLessonsID",
                        column: x => x.ClientLessonsID,
                        principalTable: "LessonList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientLesson_clientsID",
                table: "ClientLesson",
                column: "clientsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientLesson");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "LessonList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonList_ClientID",
                table: "LessonList",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonList_ClientList_ClientID",
                table: "LessonList",
                column: "ClientID",
                principalTable: "ClientList",
                principalColumn: "ID");
        }
    }
}
