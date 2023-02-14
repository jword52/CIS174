using Microsoft.EntityFrameworkCore.Migrations;

namespace Module5_Ord.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: false),
                    ContactAddress = table.Column<string>(nullable: false),
                    ContactNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { 1, "Whitestone Castle, Whitestone", "Grog Strongjaw", "also ale", "555-253-4764" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { 2, "Jedi Temple, Galactic City", "Obi-Wan Kenobi", "Jedi Master", "555-367-2311" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { 3, "221B Baker Street, London", "Sherlock Holmes", "Detective", "555-221-2583" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
