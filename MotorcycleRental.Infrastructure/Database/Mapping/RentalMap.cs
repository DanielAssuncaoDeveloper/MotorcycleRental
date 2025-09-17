using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Entities;
using MotorcycleRental.Infrastructure.Database.Mapping.Common;
using MotorcycleRental.Infrastructure.Database.Mapping.Utils;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal class RentalMap : MappingBase<RentalEntity>
    {
        public RentalMap() : base("rental")
        { }

        public override void ApplyConfiguration(EntityTypeBuilder<RentalEntity> b)
        {
            b.Property(x => x.DeliveryManId)
                .HasColumnName("delivery_man_id")
                .IsRequired();

            b.Property(x => x.MotorcycleId)
                .HasColumnName("motorcycle_id")
                .IsRequired();

            b.Property(x => x.RentalPlanId)
                .HasColumnName("rental_plan_id")
                .IsRequired();

            b.Property(x => x.GrossAmount)
                .HasColumnName("gross_amount")
                .HasColumnType("numeric(14,4)")
                .IsRequired();

            b.Property(x => x.NetAmount)
                .HasColumnName("net_amount")
                .HasColumnType("numeric(14,4)")
                .IsRequired();

            b.Property(x => x.FineAmount)
                .HasColumnName("fine_amount")
                .HasColumnType("numeric(14,4)")
                .IsRequired();

            b.Property(x => x.StartDate)
                .HasColumnName("start_date")
                .IsDateTimeColumn()
                .IsRequired();

            b.Property(x => x.ExpectedEndDate)
                .HasColumnName("expected_end_date")
                .IsDateTimeColumn()
                .IsRequired();

            b.Property(x => x.EndDate)
                .HasColumnName("end_date")
                .IsDateTimeColumn()
                .IsRequired();

            b.Property(x => x.ReturnDate)
                .HasColumnName("return_date")
                .IsDateTimeColumn()
                .IsRequired(false);

            b.HasOne(x => x.DeliveryMan)
                .WithMany(x => x.Rentals)
                .HasForeignKey(x => x.DeliveryManId)
                .OnDelete(DeleteBehavior.Restrict);

            b.HasOne(x => x.Motorcycle)
                .WithMany(x => x.Rentals)
                .HasForeignKey(x => x.MotorcycleId)
                .OnDelete(DeleteBehavior.Restrict);

            b.HasOne(x => x.RentalPlan)
                .WithMany()
                .HasForeignKey(x => x.RentalPlanId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
