using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibsterFinalProj.Migrations
{
    /// <inheritdoc />
    public partial class NewMig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookListCoverImage",
                table: "BookLists");

            migrationBuilder.DropColumn(
                name: "NumberOFBooksInLibrary",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Books");

            migrationBuilder.AddColumn<byte[]>(
                name: "CoverImage",
                table: "Books",
                type: "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "BookListCoverImage",
                table: "BookLists",
                type: "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOFBooksInLibrary",
                table: "Authors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
