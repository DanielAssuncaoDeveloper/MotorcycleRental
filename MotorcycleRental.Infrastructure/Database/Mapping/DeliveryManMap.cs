using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Constants;
using MotorcycleRental.Domain.Entities;
using MotorcycleRental.Infrastructure.Database.Mapping.Common;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal class DeliveryManMap : MappingBase<DeliveryManEntity>
    {
        public DeliveryManMap() : base("delivery_man") { }

        public override void ApplyConfiguration(EntityTypeBuilder<DeliveryManEntity> b)
        {
            b.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(FieldLengths.DeliveryMan.Name)
                .IsRequired();

            b.Property(x => x.Cnpj)
                .HasColumnName("cnpj")
                .HasMaxLength(FieldLengths.DeliveryMan.Cnpj)
                .IsRequired();
            
            b.Property(x => x.BirthDate)
                .HasColumnName("birth_date")
                .HasColumnType("date")
                .IsRequired();

            b.Property(x => x.DriverLicenseNumber)
                .HasColumnName("driver_license_number")
                .HasMaxLength(FieldLengths.DeliveryMan.DriverLicenseNumber)
                .IsRequired();

            b.Property(x => x.DriverLicenseType)
                .HasColumnName("driver_license_type")
                .HasConversion<int>()
                .HasColumnType("smallint")
                .IsRequired();

            b.Property(x => x.DriverLicenseImagePath)
                .HasColumnName("driver_license_image_path");

            b.HasIndex(x => x.Cnpj)
                .IsUnique()
                .HasDatabaseName("ux_delivery_man_cnpj");

            b.HasIndex(x => x.DriverLicenseNumber)
                .IsUnique()
                .HasDatabaseName("ux_delivery_man_dln");
        }
    }
}
