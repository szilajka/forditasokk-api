using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class PublisherConfiguration : BaseEntityConfiguration<Publisher>
    {
        public override void Configure(EntityTypeBuilder<Publisher> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                .HasMaxLength(256)
                .IsUnicode()
                .IsRequired();

            builder.Property(p => p.LogoPath)
                .HasMaxLength(512)
                .IsUnicode()
                .IsRequired();

            builder.HasMany(p => p.Channels)
                .WithOne(pc => pc.Publisher)
                .HasForeignKey(pc => pc.PublisherId);

            builder.HasMany(p => p.Artists)
                .WithOne(a => a.Publisher)
                .HasForeignKey(a => a.PublisherId);
        }
    }
}
