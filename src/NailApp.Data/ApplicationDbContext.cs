using Microsoft.EntityFrameworkCore;
using NailApp.Data.Entities;

namespace NailApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<UserEntity> Users { get; set; }
    }
}
