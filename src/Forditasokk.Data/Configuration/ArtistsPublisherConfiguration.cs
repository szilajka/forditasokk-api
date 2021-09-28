using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Forditasokk.Data.Configuration
{
    public class ArtistsPublisherConfiguration : ModificationDateEntityConfiguration<ArtistsPublisher>
    {
        public override void Configure(EntityTypeBuilder<ArtistsPublisher> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.ContractStart)
                .HasConversion(dt => dt, dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc))
                .IsRequired();

            builder.Property(b => b.ContractEnd)
               .HasConversion(dt => dt, dt => dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : dt)
               .IsRequired();

            builder.HasOne(b => b.Artist)
                .WithMany(b => b.Publishers)
                .HasForeignKey(b => b.ArtistId);

            builder.HasOne(b => b.Publisher)
                .WithMany(b => b.Artists)
                .HasForeignKey(b => b.PublisherId);

            builder.HasKey(b => new { b.ArtistId, b.PublisherId });
        }
    }
}
