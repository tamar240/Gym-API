using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonList_TrainerList_TrainerID1",
                table: "LessonList");

            migrationBuilder.DropIndex(
                name: "IX_LessonList_TrainerID1",
                table: "LessonList");

            migrationBuilder.DropColumn(
                name: "TrainerID1",
                table: "LessonList");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerID",
                table: "LessonList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_LessonList_TrainerID",
                table: "LessonList",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonList_TrainerList_TrainerID",
                table: "LessonList",
                column: "TrainerID",
                principalTable: "TrainerList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonList_TrainerList_TrainerID",
                table: "LessonList");

            migrationBuilder.DropIndex(
                name: "IX_LessonList_TrainerID",
                table: "LessonList");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerID",
                table: "LessonList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TrainerID1",
                table: "LessonList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonList_TrainerID1",
                table: "LessonList",
                column: "TrainerID1");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonList_TrainerList_TrainerID1",
                table: "LessonList",
                column: "TrainerID1",
                principalTable: "TrainerList",
                principalColumn: "ID");
        }
    }
}
