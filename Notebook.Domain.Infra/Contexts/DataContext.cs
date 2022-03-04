using Microsoft.EntityFrameworkCore;
using Notebook.Domain.Entities;

namespace Notebook.Domain.Infra.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }

    public DbSet<Contact> Contacts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite("DataSource=app.db;Cache=Shared");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().ToTable("Company");
        modelBuilder.Entity<Company>().HasKey(x => x.Id).HasName("PK_Id");
        modelBuilder.Entity<Company>().Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        modelBuilder.Entity<Company>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(160);
        modelBuilder.Entity<Company>().Property(x => x.CreatedDate).HasColumnType("smalldate");

        modelBuilder.Entity<Contact>().ToTable("Contact");
        modelBuilder.Entity<Contact>().HasKey(x => x.Id).HasName("PK_Id");
        modelBuilder.Entity<Contact>().Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        modelBuilder.Entity<Contact>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(160);

    }
}