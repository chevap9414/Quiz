using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDemo.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "HN", "LastName", "Phone" },
                values: new object[,]
                {
                    { 6L, "test06@quiz.com", "ทดสอบ06", "000006", "นามสกุล06", "0810000006" },
                    { 7L, "test07@quiz.com", "ทดสอบ07", "000007", "นามสกุล07", "0810000007" },
                    { 8L, "test08@quiz.com", "ทดสอบ08", "000008", "นามสกุล08", "0810000008" },
                    { 9L, "test09@quiz.com", "ทดสอบ09", "000009", "นามสกุล09", "0810000009" },
                    { 10L, "test10@quiz.com", "ทดสอบ10", "000010", "นามสกุล10", "0810000010" },
                    { 11L, "test11@quiz.com", "ทดสอบ11", "000011", "นามสกุล11", "0810000011" },
                    { 12L, "test12@quiz.com", "ทดสอบ12", "000012", "นามสกุล12", "0810000012" },
                    { 13L, "test13@quiz.com", "ทดสอบ13", "000013", "นามสกุล13", "0810000013" },
                    { 14L, "test14@quiz.com", "ทดสอบ14", "000014", "นามสกุล14", "0810000014" },
                    { 15L, "test15@quiz.com", "ทดสอบ15", "000015", "นามสกุล15", "0810000015" },
                    { 16L, "test16@quiz.com", "ทดสอบ16", "000016", "นามสกุล16", "0810000016" },
                    { 17L, "test17@quiz.com", "ทดสอบ17", "000017", "นามสกุล17", "0810000017" },
                    { 18L, "test18@quiz.com", "ทดสอบ18", "000018", "นามสกุล18", "0810000018" },
                    { 19L, "test19@quiz.com", "ทดสอบ19", "000019", "นามสกุล19", "0810000019" },
                    { 20L, "test20@quiz.com", "ทดสอบ20", "000020", "นามสกุล20", "0810000020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20L);
        }
    }
}
