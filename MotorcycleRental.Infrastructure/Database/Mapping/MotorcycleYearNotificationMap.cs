using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Constants;
using MotorcycleRental.Domain.Entities;
using MotorcycleRental.Infrastructure.Database.Mapping.Common;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal class MotorcycleYearNotificationMap : MappingBase<MotorcycleYearNotificationEntity>
    {
        public MotorcycleYearNotificationMap() : base("motorcycle_year_notification")
        { }

        public override void ApplyConfiguration(EntityTypeBuilder<MotorcycleYearNotificationEntity> b)
        {
            b.Property(x => x.MotorcycleId)
                .HasColumnName("motorcycle_id")
                .IsRequired();

            b.Property(x => x.LicensePlate)
                .HasColumnName("license_plate")
                .HasMaxLength(FieldLengths.Motorcycle.LicensePlate)
                .IsRequired();

            b.Property(x => x.Year)
                .HasColumnName("year")
                .IsRequired();

            b.Property(x => x.Model)
                .HasColumnName("model")
                .HasMaxLength(FieldLengths.Motorcycle.Model)
                .IsRequired();
            
            b.HasOne(x => x.Motorcycle)
                .WithMany()
                .HasForeignKey(x => x.MotorcycleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
