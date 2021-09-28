using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class ArtistSongFeatureConfiguration : BaseEntityConfiguration<ArtistSongFeature>
    {
        public override void Configure(EntityTypeBuilder<ArtistSongFeature> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.IsMainArtist)
                .IsRequired();

            builder.HasOne(b => b.Artist)
                .WithMany(b => b.Songs)
                .HasForeignKey(b => b.ArtistId);

            builder.HasOne(b => b.Song)
                .WithMany(b => b.Artists)
                .HasForeignKey(b => b.SongId);
        }
    }
}
