using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MotorcycleRental.Infrastructure.Database.Mapping.Utils
{
    public static class MappingUtils
    {
        public static PropertyBuilder<DateTime> IsDateTimeColumn(this PropertyBuilder<DateTime> builder) =>
            builder.HasColumnType("timestamp without time zone")
            .HasConversion(
                v => v,
                v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
            );

        public static PropertyBuilder<DateTime?> IsDateTimeColumn(this PropertyBuilder<DateTime?> builder) =>
            builder.HasColumnType("timestamp without time zone")
            .HasConversion(
                v => v,
                v => v != null ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : null
            );
    }
}
