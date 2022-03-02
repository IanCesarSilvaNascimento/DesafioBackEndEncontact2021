using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Infra.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite("DataSource=app.db;Cache=Shared");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().ToTable("Company");
        modelBuilder.Entity<Company>().Property(x => x.Id);
        modelBuilder.Entity<Company>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(160);
        modelBuilder.Entity<Company>().Property(x => x.User).HasColumnType("varchar").HasMaxLength(160);
        modelBuilder.Entity<Company>().HasIndex(x => x.User);
        modelBuilder.Entity<Company>().Property(x => x.CreatedDate).HasColumnType("smalldate");



    }
}