using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Entities;
using MotorcycleRental.Infrastructure.Database.Mapping.Common;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal class RentalPlanMap : MappingBase<RentalPlanEntity>
    {
        public RentalPlanMap() : base("rental_plan")
        { }

        public override void ApplyConfiguration(EntityTypeBuilder<RentalPlanEntity> b)
        {
            b.Property(x => x.PlanDays)
              .HasColumnName("plan_days")
              .IsRequired();

            b.Property(x => x.DailyRate)
                .HasColumnName("daily_rate")
                .HasColumnType("numeric(10,2)")
                .IsRequired();

            b.Property(x => x.IsActive)
                .HasColumnName("is_active")
                .HasColumnType("boolean")
                .HasDefaultValue(true)
                .IsRequired();
        }
    }
}
