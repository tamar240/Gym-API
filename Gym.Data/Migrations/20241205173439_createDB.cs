using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthFund = table.Column<int>(type: "int", nullable: false),
                    IsActiveClient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrainerList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfFitness = table.Column<int>(type: "int", nullable: false),
                    IsActiveTrainer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LessonList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetAudience = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    During = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    TrainerID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LessonList_ClientList_ClientID",
                        column: x => x.ClientID,
                        principalTable: "ClientList",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LessonList_TrainerList_TrainerID1",
                        column: x => x.TrainerID1,
                        principalTable: "TrainerList",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonList_ClientID",
                table: "LessonList",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonList_TrainerID1",
                table: "LessonList",
                column: "TrainerID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonList");

            migrationBuilder.DropTable(
                name: "ClientList");

            migrationBuilder.DropTable(
                name: "TrainerList");
        }
    }
}
