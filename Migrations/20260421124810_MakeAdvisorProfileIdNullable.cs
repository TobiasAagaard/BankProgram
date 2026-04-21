using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShellBank.Migrations
{
    /// <inheritdoc />
    public partial class MakeAdvisorProfileIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Advisors_AdvisorProfileId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "AdvisorProfileId",
                table: "Customers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Advisors_AdvisorProfileId",
                table: "Customers",
                column: "AdvisorProfileId",
                principalTable: "Advisors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Advisors_AdvisorProfileId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "AdvisorProfileId",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Advisors_AdvisorProfileId",
                table: "Customers",
                column: "AdvisorProfileId",
                principalTable: "Advisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
