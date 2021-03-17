using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataAccess
{
    public class AfishaBishkekContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly string _connectionString;
        public AfishaBishkekContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public AfishaBishkekContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlServer(_connectionString);

        public class Program
        {
             static void Main() { }
        }
    }
}
