using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migadd_sender_receiver_name1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context",
                table: "WriterMessages",
                newName: "SenderName");

            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "WriterMessages");

            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "WriterMessages");

            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "WriterMessages",
                newName: "Context");
        }
    }
}
