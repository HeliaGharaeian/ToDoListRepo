using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class AddNewProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Job",
                table: "toDoListContexts",
                newName: "Content");

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                table: "toDoListContexts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "toDoListContexts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delete",
                table: "toDoListContexts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "toDoListContexts");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "toDoListContexts",
                newName: "Job");
        }
    }
}
