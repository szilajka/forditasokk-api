using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class SongChannelConfiguration : ChannelConfiguration<SongChannel>
    {
        public override void Configure(EntityTypeBuilder<SongChannel> builder)
        {
            base.Configure(builder);

            builder.HasOne(b => b.Song)
                .WithMany(b => b.Channels)
                .HasForeignKey(b => b.SongId);
        }
    }
}
