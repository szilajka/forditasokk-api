using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forditasokk.Data.Configuration
{
    public class TranslationConfiguration : BaseEntityConfiguration<Translation>
    {
        public override void Configure(EntityTypeBuilder<Translation> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.Title)
                .HasMaxLength(256)
                .IsUnicode()
                .IsRequired();

            builder.Property(b => b.Lyrics)
                .IsUnicode()
                .IsRequired();

            builder.Property(b => b.TranslatorId)
                .HasMaxLength(128)
                .IsUnicode()
                .IsRequired();

            builder.HasOne(b => b.Song)
                .WithMany(b => b.Translations)
                .HasForeignKey(b => b.SongId);
        }
    }
}
