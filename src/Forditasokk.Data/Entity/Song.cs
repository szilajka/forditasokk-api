using System.Collections.Generic;

namespace Forditasokk.Data.Entity
{
    public class Song : BaseEntity
    {
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public long AlbumId { get; set; }
        public Album Album { get; set; }
        public IList<SongChannel> Channels { get; set; }
        public IList<ArtistSongFeature> Artists { get; set; }
        public IList<Translation> Translations { get; set; }
    }
}
