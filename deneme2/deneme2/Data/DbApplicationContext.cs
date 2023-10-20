
using deneme2.Models;
using Microsoft.EntityFrameworkCore;

namespace deneme2.Data
{
    public class DbApplicationContext :DbContext

    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserCategory> UserCategory { get; set; }

    }
}


