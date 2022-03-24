using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDemo.Migrations
{
    public partial class InitialCreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HN = table.Column<string>(type: "varchar(6)", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(10)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "HN", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1L, "test01@quiz.com", "ทดสอบ01", "000001", "นามสกุล01", "0810000001" },
                    { 2L, "test02@quiz.com", "ทดสอบ02", "000002", "นามสกุล02", "0810000002" },
                    { 3L, "test03@quiz.com", "ทดสอบ03", "000003", "นามสกุล03", "0810000003" },
                    { 4L, "test04@quiz.com", "ทดสอบ04", "000004", "นามสกุล04", "0810000004" },
                    { 5L, "test05@quiz.com", "ทดสอบ05", "000005", "นามสกุล05", "0810000005" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
