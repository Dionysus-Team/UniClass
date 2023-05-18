using Microsoft.EntityFrameworkCore;
using UniClass.Domain.Features.Entities;

namespace UniClass.Infra.Data
{
    public class UniClassDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Matter> Matters { get; set; }

        public UniClassDBContext(DbContextOptions<UniClassDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
