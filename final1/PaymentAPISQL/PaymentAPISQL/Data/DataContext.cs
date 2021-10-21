using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PaymentAPISQL.Models;

namespace PaymentAPISQL.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Payment> Payments { get; init; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
