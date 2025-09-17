using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Constants;
using MotorcycleRental.Domain.Entities;
using MotorcycleRental.Infrastructure.Database.Mapping.Common;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal class MotorcycleMap : MappingBase<MotorcycleEntity>
    {
        public MotorcycleMap() : base("motorcycle") { }
        
        public override void ApplyConfiguration(EntityTypeBuilder<MotorcycleEntity> b)
        {
            b.Property(x => x.Year)
                .HasColumnName("year")
                .IsRequired();

            b.Property(x => x.Model)
                .HasColumnName("model")
                .HasMaxLength(FieldLengths.Motorcycle.Model)
                .IsRequired();

            b.Property(x => x.LicensePlate)
                .HasColumnName("license_plate")
                .HasMaxLength(FieldLengths.Motorcycle.LicensePlate)
                .IsRequired();

            b.HasIndex(x => x.LicensePlate)
                .IsUnique()
                .HasDatabaseName("ux_motorcycle_license_plate");
        }
    }
}
