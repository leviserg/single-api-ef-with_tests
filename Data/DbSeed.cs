using single_api.Models;

namespace single_api.Data
{
    public class DbSeed
    {
        private readonly AppDbContext _dbContext;

        public DbSeed(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            _dbContext.Orders.AddRange(
                new Order { Description = "Order 1" },
                new Order { Description = "Order 2" },
                new Order { Description = "Order 3" }
                );
            _dbContext.SaveChanges();
        }
    }
}
