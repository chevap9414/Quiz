using Microsoft.EntityFrameworkCore;
using QuizDemo.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas
{
    public class ApplicationSqlContext : DbContext
    {
        public ApplicationSqlContext(DbContextOptions<ApplicationSqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Thai_100_CI_AS");
            modelBuilder.Entity<User>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, HN = "000001", FirstName = "ทดสอบ01", LastName = "นามสกุล01", Phone = "0810000001", Email = "test01@quiz.com" },
                new User { Id = 2, HN = "000002", FirstName = "ทดสอบ02", LastName = "นามสกุล02", Phone = "0810000002", Email = "test02@quiz.com" },
                new User { Id = 3, HN = "000003", FirstName = "ทดสอบ03", LastName = "นามสกุล03", Phone = "0810000003", Email = "test03@quiz.com" },
                new User { Id = 4, HN = "000004", FirstName = "ทดสอบ04", LastName = "นามสกุล04", Phone = "0810000004", Email = "test04@quiz.com" },
                new User { Id = 5, HN = "000005", FirstName = "ทดสอบ05", LastName = "นามสกุล05", Phone = "0810000005", Email = "test05@quiz.com" },
                new User { Id = 6, HN = "000006", FirstName = "ทดสอบ06", LastName = "นามสกุล06", Phone = "0810000006", Email = "test06@quiz.com" },
                new User { Id = 7, HN = "000007", FirstName = "ทดสอบ07", LastName = "นามสกุล07", Phone = "0810000007", Email = "test07@quiz.com" },
                new User { Id = 8, HN = "000008", FirstName = "ทดสอบ08", LastName = "นามสกุล08", Phone = "0810000008", Email = "test08@quiz.com" },
                new User { Id = 9, HN = "000009", FirstName = "ทดสอบ09", LastName = "นามสกุล09", Phone = "0810000009", Email = "test09@quiz.com" },
                new User { Id = 10, HN = "000010", FirstName = "ทดสอบ10", LastName = "นามสกุล10", Phone = "0810000010", Email = "test10@quiz.com" },
                new User { Id = 11, HN = "000011", FirstName = "ทดสอบ11", LastName = "นามสกุล11", Phone = "0810000011", Email = "test11@quiz.com" },
                new User { Id = 12, HN = "000012", FirstName = "ทดสอบ12", LastName = "นามสกุล12", Phone = "0810000012", Email = "test12@quiz.com" },
                new User { Id = 13, HN = "000013", FirstName = "ทดสอบ13", LastName = "นามสกุล13", Phone = "0810000013", Email = "test13@quiz.com" },
                new User { Id = 14, HN = "000014", FirstName = "ทดสอบ14", LastName = "นามสกุล14", Phone = "0810000014", Email = "test14@quiz.com" },
                new User { Id = 15, HN = "000015", FirstName = "ทดสอบ15", LastName = "นามสกุล15", Phone = "0810000015", Email = "test15@quiz.com" },
                new User { Id = 16, HN = "000016", FirstName = "ทดสอบ16", LastName = "นามสกุล16", Phone = "0810000016", Email = "test16@quiz.com" },
                new User { Id = 17, HN = "000017", FirstName = "ทดสอบ17", LastName = "นามสกุล17", Phone = "0810000017", Email = "test17@quiz.com" },
                new User { Id = 18, HN = "000018", FirstName = "ทดสอบ18", LastName = "นามสกุล18", Phone = "0810000018", Email = "test18@quiz.com" },
                new User { Id = 19, HN = "000019", FirstName = "ทดสอบ19", LastName = "นามสกุล19", Phone = "0810000019", Email = "test19@quiz.com" },
                new User { Id = 20, HN = "000020", FirstName = "ทดสอบ20", LastName = "นามสกุล20", Phone = "0810000020", Email = "test20@quiz.com" }
                );
        }

        public DbSet<User> Users { get; set; }
    }
}
