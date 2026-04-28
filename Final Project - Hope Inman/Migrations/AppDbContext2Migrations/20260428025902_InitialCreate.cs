using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project___Hope_Inman.Migrations.AppDbContext2Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    football = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baseball = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    basketball = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soccer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hockey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
