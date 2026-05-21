using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Models;

namespace SchoolLabApp.Data
{
    public class SchoolLabAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Damage> Damages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proekt_grupa_milanov;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                 new Role { Id = 1, Name = "Admin" },
                 new Role { Id = 2, Name = "Teacher" },
                 new Role { Id = 3, Name = "Student" },
                 new Role { Id = 4, Name = "Technician" }
            );

            modelBuilder.Entity<Models.User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Models.User>()
                .HasOne(u => u.Person)
                .WithMany()
                .HasForeignKey(u => u.PersonId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Asset>()
                .HasOne(a => a.Category)
                .WithMany(c => c.Assets)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Asset)
                .WithMany(a => a.Loans)
                .HasForeignKey(l => l.AssetId);

            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Person)
                .WithMany(p => p.Loans)
                .HasForeignKey(l => l.PersonId);

            modelBuilder.Entity<Damage>()
                .HasOne(d => d.Asset)
                .WithMany(a => a.Damages)
                .HasForeignKey(d => d.AssetId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
