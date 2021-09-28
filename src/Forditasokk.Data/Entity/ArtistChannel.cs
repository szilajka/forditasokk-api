namespace Forditasokk.Data.Entity
{
    public class ArtistChannel : Channel
    {
        public long ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
