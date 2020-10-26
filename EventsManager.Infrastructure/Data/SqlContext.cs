using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EventsManager.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Task> Task { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("WhenCreated") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("WhenCreated").CurrentValue = DateTime.Now;
                    entry.Property("WhenModified").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("WhenCreated").IsModified = false;
                    entry.Property("WhenModified").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}