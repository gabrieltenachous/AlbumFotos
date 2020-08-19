using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumFotos.Migrations
{
    public partial class atualizarDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Albuns_AlbumId1",
                table: "Imagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Albuns_AlbumId2",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_AlbumId1",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_AlbumId2",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "AlbumId1",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "AlbumId2",
                table: "Imagens");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Imagens",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Imagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_AlbumId",
                table: "Imagens",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens",
                column: "AlbumId",
                principalTable: "Albuns",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_AlbumId",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Imagens");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Imagens",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId1",
                table: "Imagens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId2",
                table: "Imagens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_AlbumId1",
                table: "Imagens",
                column: "AlbumId1");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_AlbumId2",
                table: "Imagens",
                column: "AlbumId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Albuns_AlbumId1",
                table: "Imagens",
                column: "AlbumId1",
                principalTable: "Albuns",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Albuns_AlbumId2",
                table: "Imagens",
                column: "AlbumId2",
                principalTable: "Albuns",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
