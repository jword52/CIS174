using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OlympicGames.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LocationID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                    table.ForeignKey(
                        name: "FK_Countries_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID");
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GameName" },
                values: new object[,]
                {
                    { "po", "Paralympics" },
                    { "so", "Summer Olympics" },
                    { "wo", "Winter Olympics" },
                    { "yo", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { "in", "Indoors" },
                    { "out", "Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "SportName" },
                values: new object[,]
                {
                    { "arc", "Archery" },
                    { "bob", "Bobsleigh" },
                    { "bre", "Breakdancing" },
                    { "can", "Canoe Sprint" },
                    { "cur", "Curling" },
                    { "cyc", "Road Cycling" },
                    { "div", "Diving" },
                    { "ska", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "FlagImg", "GameID", "LocationID", "SportID" },
                values: new object[,]
                {
                    { "AT", "Austria", "AT.png", "po", "out", "can" },
                    { "BR", "Brazil", "BR.png", "so", "out", "cyc" },
                    { "CA", "Canada", "CA.png", "wo", "in", "cur" },
                    { "CN", "China", "CN.png", "so", "in", "div" },
                    { "CY", "Cyprus", "CY.png", "yo", "in", "bre" },
                    { "DE", "Germany", "DE.png", "so", "in", "div" },
                    { "FI", "Finland", "FI.png", "yo", "out", "ska" },
                    { "FR", "France", "FR.png", "yo", "in", "bre" },
                    { "GB", "Great Britain", "GB.png", "wo", "in", "cur" },
                    { "IT", "Italy", "IT.png", "wo", "out", "bob" },
                    { "JM", "Jamaica", "JM.png", "wo", "out", "bob" },
                    { "JP", "Japan", "JP.png", "wo", "out", "bob" },
                    { "MX", "Mexico", "MX.png", "so", "in", "div" },
                    { "NL", "Netherlands", "NL.png", "so", "out", "cyc" },
                    { "PK", "Pakistan", "PK.png", "po", "out", "can" },
                    { "PT", "Portugal", "PT.png", "yo", "out", "ska" },
                    { "RU", "Russia", "RU.png", "yo", "in", "bre" },
                    { "SE", "Sweden", "SE.png", "wo", "in", "cur" },
                    { "SK", "Slovakia", "SK.png", "yo", "out", "ska" },
                    { "TH", "Thailand", "TH.png", "po", "in", "arc" },
                    { "UA", "Ukraine", "UA.png", "po", "in", "arc" },
                    { "US", "USA", "US.png", "so", "out", "cyc" },
                    { "UY", "Uruguay", "UY.png", "po", "in", "arc" },
                    { "ZW", "Zimbabwe", "ZW.png", "po", "out", "can" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LocationID",
                table: "Countries",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
