using AuthAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.DBContext
{
    public class StockMarketDBContext : DbContext
    {
        public StockMarketDBContext(DbContextOptions<StockMarketDBContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
    }
}
