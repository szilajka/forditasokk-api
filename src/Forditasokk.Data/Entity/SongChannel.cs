namespace Forditasokk.Data.Entity
{
    public class SongChannel : Channel
    {
        public long SongId { get; set; }
        public Song Song { get; set; }
    }
}
