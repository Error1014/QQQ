using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    public partial class FixEmploy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emplois_Depts_DeptId",
                table: "Emplois");

            migrationBuilder.DropForeignKey(
                name: "FK_Emplois_Otdels_OtdelId",
                table: "Emplois");

            migrationBuilder.AlterColumn<int>(
                name: "OtdelId",
                table: "Emplois",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeptId",
                table: "Emplois",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Emplois_Depts_DeptId",
                table: "Emplois",
                column: "DeptId",
                principalTable: "Depts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emplois_Otdels_OtdelId",
                table: "Emplois",
                column: "OtdelId",
                principalTable: "Otdels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emplois_Depts_DeptId",
                table: "Emplois");

            migrationBuilder.DropForeignKey(
                name: "FK_Emplois_Otdels_OtdelId",
                table: "Emplois");

            migrationBuilder.AlterColumn<int>(
                name: "OtdelId",
                table: "Emplois",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeptId",
                table: "Emplois",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emplois_Depts_DeptId",
                table: "Emplois",
                column: "DeptId",
                principalTable: "Depts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emplois_Otdels_OtdelId",
                table: "Emplois",
                column: "OtdelId",
                principalTable: "Otdels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
