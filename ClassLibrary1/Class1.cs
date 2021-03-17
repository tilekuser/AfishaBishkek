using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


namespace ClassLibrary1
{
    public class Class1 : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly string _connectionString;
        public Class1(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Class1(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlServer(_connectionString);
    }
}
