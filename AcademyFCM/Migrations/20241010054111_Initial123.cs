using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyFCM.Migrations
{
    /// <inheritdoc />
    public partial class Initial123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "EndTime",
            //    table: "Sections");

            //migrationBuilder.DropColumn(
            //    name: "StartTime",
            //    table: "Sections");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<TimeSpan>(
            //    name: "EndTime",
            //    table: "Sections",
            //    type: "time",
            //    nullable: false,
            //    defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            //migrationBuilder.AddColumn<TimeSpan>(
            //    name: "StartTime",
            //    table: "Sections",
            //    type: "time",
            //    nullable: false,
            //    defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
