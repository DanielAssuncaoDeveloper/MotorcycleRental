using Microsoft.EntityFrameworkCore;
using MotorcycleRental.Infrastructure.Database.Mapping;

namespace MotorcycleRental.Infrastructure.Database
{
    public class MotorcycleRentalContext : DbContext
    {
        public MotorcycleRentalContext(DbContextOptions<MotorcycleRentalContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MappingBase<>).Assembly);
        }
    }
}
