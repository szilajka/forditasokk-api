using Forditasokk.Data.Configuration;
using Forditasokk.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Forditasokk.Data.Data
{
    public class ForditasokkDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistChannel> ArtistChannels { get; set; }
        public DbSet<ArtistSongFeature> ArtistSongFeatures { get; set; }
        public DbSet<ArtistsPublisher> ArtistsPublishers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublisherChannel> PublisherChannels { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongChannel> SongChannels { get; set; }
        public DbSet<Translation> Translations { get; set; }


        public ForditasokkDbContext([NotNull] DbContextOptions<ForditasokkDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArtistConfiguration).Assembly);
        }
    }
}
