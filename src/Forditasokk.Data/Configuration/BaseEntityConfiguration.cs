using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Forditasokk.Data.Configuration
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .IsRequired();

            builder.Property(b => b.CreatedDate)
                .HasConversion(dt => dt, dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc))
                .IsRequired();

            builder.Property(b => b.CreatedBy)
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(b => b.UpdatedDate)
                .HasConversion(dt => dt, dt => dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : dt);

            builder.Property(b => b.UpdatedBy)
                .HasMaxLength(128);

            builder.Property(b => b.DeletedDate)
                .HasConversion(dt => dt, dt => dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : dt);

            builder.Property(b => b.DeletedBy)
                .HasMaxLength(128);
        }
    }
}
