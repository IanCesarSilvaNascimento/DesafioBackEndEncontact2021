using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Infra.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }

    public DbSet<ContactBook> ContactBooks { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite("DataSource=app.db;Cache=Shared");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(x =>
        {
            x.ToTable("Company");
            x.HasKey(x => x.Id);
            x.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            x.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(160);
            x.Property(x => x.CreatedDate).HasColumnType("SMALLDATETIME");

        });

        modelBuilder.Entity<ContactBook>(x =>
       {
           x.ToTable("ContactBook");
           x.HasKey(x => x.Id);
           x.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
           x.Property(x => x.Name).HasColumnType("VARCHAR").HasMaxLength(160);
           x.HasMany(x => x.Company).WithOne().OnDelete(DeleteBehavior.Cascade);

       });

       modelBuilder.Entity<ContactBook>()
        .Navigation(b => b.Company)
        .UsePropertyAccessMode(PropertyAccessMode.Property);

    }
}