using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApiControlStock.Data
{
    public class DbStockContext : DbContext
    {
        public DbStockContext(DbContextOptions<DbStockContext> options) : base(options) { }

    }
}