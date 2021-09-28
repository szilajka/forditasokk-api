using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class ChannelConfiguration<TEntity> : BaseEntityConfiguration<TEntity> where TEntity : Channel
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.ChannelType)
                .IsRequired();

            builder.Property(b => b.Link)
                .HasMaxLength(512)
                .IsUnicode()
                .IsRequired();
        }
    }
}
