using Microsoft.EntityFrameworkCore.Migrations;

namespace Work.Web.Migrations
{
    public partial class AddPic1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Courses_CourseId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "Courses",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseId",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Courses_CourseId",
                table: "Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
