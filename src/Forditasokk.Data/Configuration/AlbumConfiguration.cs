using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Forditasokk.Data.Configuration
{
    public class AlbumConfiguration : BaseEntityConfiguration<Album>
    {
        public override void Configure(EntityTypeBuilder<Album> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.Name)
                .HasMaxLength(256)
                .IsUnicode()
                .IsRequired();

            builder.Property(b => b.ReleaseDate)
                .HasConversion(dt => dt, dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc))
                .IsRequired();

            builder.Property(b => b.CoverPath)
                .HasMaxLength(512)
                .IsUnicode();

            builder.HasOne(b => b.Artist)
                .WithMany(b => b.Albums)
                .HasForeignKey(b => b.ArtistId);

            builder.HasMany(b => b.Songs)
                .WithOne(b => b.Album)
                .HasForeignKey(b => b.AlbumId);
        }
    }
}
