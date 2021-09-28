using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Forditasokk.Data.Configuration
{
    public class ArtistConfiguration : BaseEntityConfiguration<Artist>
    {
        public override void Configure(EntityTypeBuilder<Artist> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.Name)
                .HasMaxLength(256)
                .IsUnicode()
                .IsRequired();

            builder.Property(b => b.DebutDate)
                .HasConversion(dt => dt, dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc))
                .IsRequired();

            builder.Property(b => b.ProfilePictureLink)
                .HasMaxLength(512)
                .IsUnicode();

            builder.Property(b => b.FansName)
                .HasMaxLength(256)
                .IsUnicode();

            builder.HasMany(b => b.Publishers)
                .WithOne(b => b.Artist)
                .HasForeignKey(b => b.ArtistId);

            builder.HasMany(b => b.Channels)
                .WithOne(b => b.Artist)
                .HasForeignKey(b => b.ArtistId);

            builder.HasMany(b => b.Albums)
                .WithOne(b => b.Artist)
                .HasForeignKey(b => b.ArtistId);

            builder.HasMany(b => b.Songs)
                .WithOne(b => b.Artist)
                .HasForeignKey(b => b.ArtistId);
        }
    }
}
