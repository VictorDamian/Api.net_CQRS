using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }
    public virtual DbSet<Product> Products {get;set;}
}
