using Microsoft.EntityFrameworkCore;

namespace SalesWebApplication.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options): base(options) { }

        #region DbSet
        public DbSet<Product> Products { get; set; }
        #endregion
    }
}
