using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class ArtistChannelConfiguration : ChannelConfiguration<ArtistChannel>
    {
        public override void Configure(EntityTypeBuilder<ArtistChannel> builder)
        {
            base.Configure(builder);

            builder.HasOne(b => b.Artist)
                .WithMany(b => b.Channels)
                .HasForeignKey(b => b.ArtistId);
        }
    }
}
