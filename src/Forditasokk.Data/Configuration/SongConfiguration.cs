using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class SongConfiguration : BaseEntityConfiguration<Song>
    {
        public override void Configure(EntityTypeBuilder<Song> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.Title)
                .HasMaxLength(256)
                .IsUnicode()
                .IsRequired();

            builder.Property(b => b.Lyrics)
                .IsUnicode()
                .IsRequired();

            builder.HasOne(b => b.Album)
                .WithMany(b => b.Songs)
                .HasForeignKey(b => b.AlbumId);

            builder.HasMany(b => b.Channels)
                .WithOne(b => b.Song)
                .HasForeignKey(b => b.SongId);

            builder.HasMany(b => b.Artists)
                .WithOne(b => b.Song)
                .HasForeignKey(b => b.SongId);
        }
    }
}
