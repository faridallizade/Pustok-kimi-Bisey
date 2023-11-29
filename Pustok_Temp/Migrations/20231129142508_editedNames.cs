using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Temp.Migrations
{
    /// <inheritdoc />
    public partial class editedNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookimages_books_BookId",
                table: "bookimages");

            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_AuthorId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_books_BookId",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_tags_tagsid",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_categories_parentcats_ParentCategoryId",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tags",
                table: "tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sliders",
                table: "sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_BookTags_tagsid",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookimages",
                table: "bookimages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parentcats",
                table: "parentcats");

            migrationBuilder.DropColumn(
                name: "tagsid",
                table: "BookTags");

            migrationBuilder.RenameTable(
                name: "tags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "sliders",
                newName: "Sliders");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "bookimages",
                newName: "Bookimages");

            migrationBuilder.RenameTable(
                name: "authors",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "parentcats",
                newName: "ParentCategories");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Sliders",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Sliders",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Sliders",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_categories_ParentCategoryId",
                table: "Categories",
                newName: "IX_Categories_ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_books_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_bookimages_BookId",
                table: "Bookimages",
                newName: "IX_Bookimages_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookimages",
                table: "Bookimages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentCategories",
                table: "ParentCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTags_TagId",
                table: "BookTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookimages_Books_BookId",
                table: "Bookimages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ParentCategories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookimages_Books_BookId",
                table: "Bookimages");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Books_BookId",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ParentCategories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_BookTags_TagId",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookimages",
                table: "Bookimages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentCategories",
                table: "ParentCategories");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "tags");

            migrationBuilder.RenameTable(
                name: "Sliders",
                newName: "sliders");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "Bookimages",
                newName: "bookimages");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "authors");

            migrationBuilder.RenameTable(
                name: "ParentCategories",
                newName: "parentcats");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "sliders",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "sliders",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "sliders",
                newName: "description");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "categories",
                newName: "IX_categories_ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "books",
                newName: "IX_books_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookimages_BookId",
                table: "bookimages",
                newName: "IX_bookimages_BookId");

            migrationBuilder.AddColumn<int>(
                name: "tagsid",
                table: "BookTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tags",
                table: "tags",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliders",
                table: "sliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookimages",
                table: "bookimages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parentcats",
                table: "parentcats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTags_tagsid",
                table: "BookTags",
                column: "tagsid");

            migrationBuilder.AddForeignKey(
                name: "FK_bookimages_books_BookId",
                table: "bookimages",
                column: "BookId",
                principalTable: "books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_AuthorId",
                table: "books",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_books_BookId",
                table: "BookTags",
                column: "BookId",
                principalTable: "books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_tags_tagsid",
                table: "BookTags",
                column: "tagsid",
                principalTable: "tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categories_parentcats_ParentCategoryId",
                table: "categories",
                column: "ParentCategoryId",
                principalTable: "parentcats",
                principalColumn: "Id");
        }
    }
}
