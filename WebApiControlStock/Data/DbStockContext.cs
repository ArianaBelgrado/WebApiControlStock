using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiControlStock.Models;

namespace WebApiControlStock.Data
{
    public class DbStockContext : DbContext
    {
        public DbStockContext(DbContextOptions<DbStockContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}