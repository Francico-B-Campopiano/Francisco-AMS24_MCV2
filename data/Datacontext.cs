using Microsoft.EntityFrameworkCore;

class DataConetext : DbContext
{
    public DataConetext(DbContextOptions<DataConetext> options) : base(options)
    {
    }

public DbSet<Color> Color { get; set; }
public DbSet<Size> Size { get; set; }
public DbSet<Product> Product { get; set; }
}