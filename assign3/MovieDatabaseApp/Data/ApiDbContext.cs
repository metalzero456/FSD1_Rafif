using Microsoft.EntityFrameworkCore;
using MovieDatabaseApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieDatabaseApp.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}