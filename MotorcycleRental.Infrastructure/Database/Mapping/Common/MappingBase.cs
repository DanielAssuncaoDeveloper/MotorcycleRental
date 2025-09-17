using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorcycleRental.Domain.Entities.Common;
using MotorcycleRental.Infrastructure.Database.Mapping.Utils;

namespace MotorcycleRental.Infrastructure.Database.Mapping
{
    internal abstract class MappingBase<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        private readonly string _tableName;

        public MappingBase(string tableName)
        {
            _tableName = tableName;
        }

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(_tableName);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(e => e.CreatedAtUtc)
                .HasColumnName("created_at_utc")
                .IsDateTimeColumn()
                .IsRequired();

            builder.Property(e => e.UpdatedAtUtc)
                .HasColumnName("updated_at_utc")
                .IsDateTimeColumn()
                .IsRequired(false);

            ApplyConfiguration(builder);
            ReplicateData(builder);
        }

        public abstract void ApplyConfiguration(EntityTypeBuilder<TEntity> builder);
        public virtual void ReplicateData(EntityTypeBuilder<TEntity> builder) { return; }

    }
}
