using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    SprintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.SprintId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: true),
                    SprintId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "DueDate", "Name" },
                values: new object[,]
                {
                    { -1, null, "No Sprint" },
                    { 1, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 1" },
                    { 2, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 2" },
                    { 3, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 3" },
                    { 4, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 4" },
                    { 5, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 5" },
                    { 6, new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 6" },
                    { 7, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 7" },
                    { 8, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 8" },
                    { 9, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 9" },
                    { 10, new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprint 10" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { "todo", "To Do" },
                    { "inprog", "In Progress" },
                    { "qa", "Quality Assurance" },
                    { "done", "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Name", "Points", "SprintId", "StatusId" },
                values: new object[,]
                {
                    { 1, "Job Number 1", "Ticket 1", 1, 1, "todo" },
                    { 3, "Job Number 3", "Ticket 3", 9, 2, "todo" },
                    { 5, "Job Number 5", "Ticket 5", 5, 3, "todo" },
                    { 7, "Job Number 7", "Ticket 7", 9, 4, "todo" },
                    { 9, "Job Number 9", "Ticket 9", 10, 5, "todo" },
                    { 2, "Job Number 2", "Ticket 2", 1, 1, "inprog" },
                    { 4, "Job Number 4", "Ticket 4", 10, 2, "inprog" },
                    { 6, "Job Number 6", "Ticket 6", 6, 3, "inprog" },
                    { 8, "Job Number 8", "Ticket 8", 3, 4, "inprog" },
                    { 10, "Job Number 10", "Ticket 10", 5, 5, "inprog" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SprintId",
                table: "Tickets",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
