using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thay ".\SQLEXPRESS" bằng Server Name trên máy bạn nếu khác
            // "StudentDb" là tên CSDL sẽ được tạo ra trong SQL Server
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
            Database=StudentDb;
            Trusted_Connection=True;
            TrustServerCertificate=True;");
        }
    }
}
