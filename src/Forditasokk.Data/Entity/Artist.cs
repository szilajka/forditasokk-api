using System;
using System.Collections.Generic;

namespace Forditasokk.Data.Entity
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DebutDate { get; set; }
        public string ProfilePictureLink { get; set; }
        public string FansName { get; set; }
        public IList<ArtistsPublisher> Publishers { get; set; }
        public IList<ArtistChannel> Channels { get; set; }
        public IList<Album> Albums { get; set; }
        public IList<ArtistSongFeature> Songs { get; set; }
    }
}
