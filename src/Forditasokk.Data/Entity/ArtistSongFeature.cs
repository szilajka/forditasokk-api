namespace Forditasokk.Data.Entity
{
    public class ArtistSongFeature : BaseEntity
    {
        public bool IsMainArtist { get; set; }
        public long ArtistId { get; set; }
        public Artist Artist { get; set; }
        public long SongId { get; set; }
        public Song Song { get; set; }
    }
}
