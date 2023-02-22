using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module5_Ord.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "Contacts",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ContactNote",
                table: "Contacts",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "Address", "Name", "Note", "Phone" },
                values: new object[] { "685 Kelly St, Queens, NY 11234", "Peter Parker", " ", "609-773-9847" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Note", "Phone" },
                values: new object[] { "899 Thomas St, Smallville, KS, 68512", "Clark Kent", " ", "632-555-0108" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Note", "Phone" },
                values: new object[] { "111 America Ln, America, America, 11111", "Steve Rogers", " ", "678-136-7092" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "ContactID");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Contacts",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Contacts",
                newName: "ContactNote");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "ContactName");

            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactID",
                keyValue: 1,
                columns: new[] { "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { "Whitestone Castle, Whitestone", "Grog Strongjaw", "also ale", "555-253-4764" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactID",
                keyValue: 2,
                columns: new[] { "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { "Jedi Temple, Galactic City", "Obi-Wan Kenobi", "Jedi Master", "555-367-2311" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactID",
                keyValue: 3,
                columns: new[] { "ContactAddress", "ContactName", "ContactNote", "ContactPhone" },
                values: new object[] { "221B Baker Street, London", "Sherlock Holmes", "Detective", "555-221-2583" });
        }
    }
}
