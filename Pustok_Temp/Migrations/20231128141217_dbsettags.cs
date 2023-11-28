using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Temp.Migrations
{
    /// <inheritdoc />
    public partial class dbsettags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_tagsid",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "tags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tags",
                table: "tags",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_tags_tagsid",
                table: "BookTags",
                column: "tagsid",
                principalTable: "tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_tags_tagsid",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tags",
                table: "tags");

            migrationBuilder.RenameTable(
                name: "tags",
                newName: "Tags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_tagsid",
                table: "BookTags",
                column: "tagsid",
                principalTable: "Tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
