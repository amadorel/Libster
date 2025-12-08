using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibsterFinalProj.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookListId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookListId",
                table: "Books",
                column: "BookListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookLists_BookListId",
                table: "Books",
                column: "BookListId",
                principalTable: "BookLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookLists_BookListId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookListId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookListId",
                table: "Books");
        }
    }
}
