using Microsoft.EntityFrameworkCore.Migrations;

namespace Banks.ApiUI.Migrations
{
    public partial class addedFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Credits_CreditId",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CreditId",
                table: "People",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_People_Credits_CreditId",
                table: "People",
                column: "CreditId",
                principalTable: "Credits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Credits_CreditId",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CreditId",
                table: "People",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Credits_CreditId",
                table: "People",
                column: "CreditId",
                principalTable: "Credits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
