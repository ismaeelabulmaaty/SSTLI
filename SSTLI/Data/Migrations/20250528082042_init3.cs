using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSTLI.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachEducationalQualification",
                table: "RegistrationsAttendanceOrOnline");

            migrationBuilder.RenameColumn(
                name: "attachNationalIdPhoto",
                table: "RegistrationsAttendanceOrOnline",
                newName: "Branch");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "RegistrationsAttendanceOrOnline",
                type: "NVARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AttachEducationalQualificationImage",
                table: "RegistrationsAttendanceOrOnline",
                type: "NVARCHAR(MAX)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "attachNationalIdImage",
                table: "RegistrationsAttendanceOrOnline",
                type: "NVARCHAR(MAX)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachEducationalQualificationImage",
                table: "RegistrationsAttendanceOrOnline");

            migrationBuilder.DropColumn(
                name: "attachNationalIdImage",
                table: "RegistrationsAttendanceOrOnline");

            migrationBuilder.RenameColumn(
                name: "Branch",
                table: "RegistrationsAttendanceOrOnline",
                newName: "attachNationalIdPhoto");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "RegistrationsAttendanceOrOnline",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)");

            migrationBuilder.AddColumn<string>(
                name: "AttachEducationalQualification",
                table: "RegistrationsAttendanceOrOnline",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
