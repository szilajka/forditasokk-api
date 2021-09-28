using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class PublisherChannelConfiguration : ChannelConfiguration<PublisherChannel>
    {
        public override void Configure(EntityTypeBuilder<PublisherChannel> builder)
        {
            base.Configure(builder);

            builder.HasOne(b => b.Publisher)
                .WithMany(b => b.Channels)
                .HasForeignKey(b => b.PublisherId);
        }
    }
}
