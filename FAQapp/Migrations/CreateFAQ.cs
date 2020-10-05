using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQapp.Migrations
{
    public partial class CreateFAQ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    TopicID = table.Column<int>(nullable: false),
                    Question = table.Column<string>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "General" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "History" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[] { 1, "Religion" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[] { 2, "Characters" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[] { 3, "Location" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[] { 4, "Faction" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "CategoryID", "TopicID", "FAQ" },
                values: new object[,]
                {
                    { 1, 1, 4, "What are the Lizardmen? A group of 4 races created by the Old Ones to oppose Chaos and teach the younger races." },
                    { 2, 1, 1, "Who are the Old Ones? A race of hyper-advanced aliens who created the Lizardmen, Elves, Dwarfs, Humans, Ogres, Giants, and Halflings." },
                    { 3, 2, 1, "Where are the Old Ones? The Old Ones either fled or died with the coming of Chaos when the Polar Gates collapsed." },
                    { 4, 1, 3, "Where do the Lizardmen live? In the jungles of Lustria and the Southlands." },
                    { 5, 1, 2, "Who is the strongest Slann? The strongest living Slann is Lord Mazdamundi." },
                    { 6, 1, 2, "Who is the strongest Saurus? Kroq'Gar, an ancient saurus leads the lizardmens armies as their general." },
                    { 7, 2, 4, "Who are the Lizardmen's main enemy? Their main enemy is Chaos." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicID",
                table: "Questions",
                column: "TopicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
