using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concreate;

public class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=ShoesDb; integrated security=true;");
    }

    public DbSet<About> Abouts { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<ContackForm> ContackForms { get; set; }

    public DbSet<Customers> Customrs { get; set; }

    public DbSet<Main> Mains { get; set; }

    public DbSet<MainSocial> MainSocials { get; set; }

    public DbSet<Products> Products { get; set; }

    public DbSet<Services> Services { get; set; }
   
}   