using Microsoft.EntityFrameworkCore;
using StockAPI.Entities;

namespace StockAPI.DBContext
{
    public class StockAPIDBContext : DbContext
    {
        public StockAPIDBContext(DbContextOptions<StockAPIDBContext> options) : base(options)
        { }

        public DbSet<Company> companies { get; set; }
        public DbSet<IPODetails> ipoDetails { get; set; }
        public DbSet<StockExchanges> stockExchanges { get; set; }
        public DbSet<StockPrice> stockPrice { get; set; }
        public DbSet<Sector> sectors { get; set; }

    }
}
