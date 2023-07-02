using BlazorServerCleanArchitecture.Domain.Common;
using BlazorServerCleanArchitecture.Domain.Common.Interfaces;
using BlazorServerCleanArchitecture.Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace BlazorServerCleanArchitecture.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 

        }

        public DbSet<Stadium> Stadiums => Set<Stadium>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
